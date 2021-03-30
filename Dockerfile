﻿ARG PULUMI_VERSION=latest
ARG PULUMI_IMAGE=pulumi/pulumi-base
FROM ${PULUMI_IMAGE}:${PULUMI_VERSION} as pulumi

# Build container
FROM ubuntu:bionic AS builder
WORKDIR /dotnet
RUN apt-get update -y && \
      apt-get install -y \
      curl \
      gpg
RUN curl -o - https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > /tmp/microsoft.asc.gpg; \
    curl -o /tmp/microsoft-prod.list https://packages.microsoft.com/config/debian/10/prod.list

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
COPY . .
RUN dotnet publish ./AutoDevOps -c Release -r linux-x64 --no-self-contained -clp:NoSummary -o /app/publish \
/p:PublishReadyToRun=true,PublishSingleFile=false

# The runtime container
FROM debian:buster-slim
WORKDIR /pulumi/projects

ARG RUNTIME_VERSION="5.0"

# We need to install ca certs before copying the ms prod debs packages
RUN --mount=target=/var/lib/apt/lists,type=cache \
    --mount=target=/var/cache/apt,type=cache \
    apt-get update -y && \
    apt-get install -y \
    ca-certificates

COPY --from=builder /tmp/microsoft.asc.gpg /etc/apt/trusted.gpg.d/microsoft.asc.gpg
COPY --from=builder /tmp/microsoft-prod.list /etc/apt/sources.list.d/microsoft-prod.list

# Install needed tools, like git
RUN --mount=target=/var/lib/apt/lists,type=cache \
    --mount=target=/var/cache/apt,type=cache \
    apt-get update -y && \
    apt-get install -y \
    git \
    dotnet-sdk-${RUNTIME_VERSION}

# Uses the workdir, copies from pulumi interim container
COPY --from=pulumi /pulumi/bin/pulumi /pulumi/bin/pulumi
COPY --from=pulumi /pulumi/bin/*-dotnet* /pulumi/bin/
ENV PATH "/pulumi/bin:${PATH}"

WORKDIR /app
COPY --from=build /app/publish .
CMD ["AutoDevOps"]
