// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class PodMonitorSpecPodMetricsEndpoints
    {
        /// <summary>
        /// BasicAuth allow an endpoint to authenticate over basic authentication. More info: https://prometheus.io/docs/operating/configuration/#endpoint
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsBasicAuth BasicAuth;
        /// <summary>
        /// Secret to mount to read bearer token for scraping targets. The secret needs to be in the same namespace as the pod monitor and accessible by the Prometheus Operator.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsBearerTokenSecret BearerTokenSecret;
        /// <summary>
        /// HonorLabels chooses the metric's labels on collisions with target labels.
        /// </summary>
        public readonly bool HonorLabels;
        /// <summary>
        /// HonorTimestamps controls whether Prometheus respects the timestamps present in scraped data.
        /// </summary>
        public readonly bool HonorTimestamps;
        /// <summary>
        /// Interval at which metrics should be scraped
        /// </summary>
        public readonly string Interval;
        /// <summary>
        /// MetricRelabelConfigs to apply to samples before ingestion.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsMetricRelabelings> MetricRelabelings;
        /// <summary>
        /// Optional HTTP URL parameters
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<string>> Params;
        /// <summary>
        /// HTTP path to scrape for metrics.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Name of the pod port this endpoint refers to. Mutually exclusive with targetPort.
        /// </summary>
        public readonly string Port;
        /// <summary>
        /// ProxyURL eg http://proxyserver:2195 Directs scrapes to proxy through this endpoint.
        /// </summary>
        public readonly string ProxyUrl;
        /// <summary>
        /// RelabelConfigs to apply to samples before ingestion. More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsRelabelings> Relabelings;
        /// <summary>
        /// HTTP scheme to use for scraping.
        /// </summary>
        public readonly string Scheme;
        /// <summary>
        /// Timeout after which the scrape is ended
        /// </summary>
        public readonly string ScrapeTimeout;
        /// <summary>
        /// Deprecated: Use 'port' instead.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsTargetPort TargetPort;
        /// <summary>
        /// TLS configuration to use when scraping the endpoint.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsTlsConfig TlsConfig;

        [OutputConstructor]
        private PodMonitorSpecPodMetricsEndpoints(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsBasicAuth basicAuth,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsBearerTokenSecret bearerTokenSecret,

            bool honorLabels,

            bool honorTimestamps,

            string interval,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsMetricRelabelings> metricRelabelings,

            ImmutableDictionary<string, ImmutableArray<string>> @params,

            string path,

            string port,

            string proxyUrl,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsRelabelings> relabelings,

            string scheme,

            string scrapeTimeout,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsTargetPort targetPort,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodMetricsEndpointsTlsConfig tlsConfig)
        {
            BasicAuth = basicAuth;
            BearerTokenSecret = bearerTokenSecret;
            HonorLabels = honorLabels;
            HonorTimestamps = honorTimestamps;
            Interval = interval;
            MetricRelabelings = metricRelabelings;
            Params = @params;
            Path = path;
            Port = port;
            ProxyUrl = proxyUrl;
            Relabelings = relabelings;
            Scheme = scheme;
            ScrapeTimeout = scrapeTimeout;
            TargetPort = targetPort;
            TlsConfig = tlsConfig;
        }
    }
}
