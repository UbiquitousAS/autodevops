// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1.Outputs
{

    [OutputType]
    public sealed class ChallengeSpecSolverDns01
    {
        /// <summary>
        /// Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01AcmeDNS AcmeDNS;
        /// <summary>
        /// Use the Akamai DNS zone management API to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01Akamai Akamai;
        /// <summary>
        /// Use the Microsoft Azure DNS API to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01AzureDNS AzureDNS;
        /// <summary>
        /// Use the Google Cloud DNS API to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01CloudDNS CloudDNS;
        /// <summary>
        /// Use the Cloudflare API to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01Cloudflare Cloudflare;
        /// <summary>
        /// CNAMEStrategy configures how the DNS01 provider should handle CNAME records when found in DNS zones.
        /// </summary>
        public readonly string CnameStrategy;
        /// <summary>
        /// Use the DigitalOcean DNS API to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01Digitalocean Digitalocean;
        /// <summary>
        /// Use RFC2136 ("Dynamic Updates in the Domain Name System") (https://datatracker.ietf.org/doc/rfc2136/) to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01Rfc2136 Rfc2136;
        /// <summary>
        /// Use the AWS Route53 API to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01Route53 Route53;
        /// <summary>
        /// Configure an external webhook based DNS01 challenge solver to manage DNS01 challenge records.
        /// </summary>
        public readonly ChallengeSpecSolverDns01Webhook Webhook;

        [OutputConstructor]
        private ChallengeSpecSolverDns01(
            ChallengeSpecSolverDns01AcmeDNS acmeDNS,

            ChallengeSpecSolverDns01Akamai akamai,

            ChallengeSpecSolverDns01AzureDNS azureDNS,

            ChallengeSpecSolverDns01CloudDNS cloudDNS,

            ChallengeSpecSolverDns01Cloudflare cloudflare,

            string cnameStrategy,

            ChallengeSpecSolverDns01Digitalocean digitalocean,

            ChallengeSpecSolverDns01Rfc2136 rfc2136,

            ChallengeSpecSolverDns01Route53 route53,

            ChallengeSpecSolverDns01Webhook webhook)
        {
            AcmeDNS = acmeDNS;
            Akamai = akamai;
            AzureDNS = azureDNS;
            CloudDNS = cloudDNS;
            Cloudflare = cloudflare;
            CnameStrategy = cnameStrategy;
            Digitalocean = digitalocean;
            Rfc2136 = rfc2136;
            Route53 = route53;
            Webhook = webhook;
        }
    }
}
