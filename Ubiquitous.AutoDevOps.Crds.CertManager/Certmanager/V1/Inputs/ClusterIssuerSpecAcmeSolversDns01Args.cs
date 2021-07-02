// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Configures cert-manager to attempt to complete authorizations by performing the DNS01 challenge flow.
    /// </summary>
    public class ClusterIssuerSpecAcmeSolversDns01Args : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.
        /// </summary>
        [Input("acmeDNS")]
        public Input<ClusterIssuerSpecAcmeSolversDns01AcmeDNSArgs>? AcmeDNS { get; set; }

        /// <summary>
        /// Use the Akamai DNS zone management API to manage DNS01 challenge records.
        /// </summary>
        [Input("akamai")]
        public Input<ClusterIssuerSpecAcmeSolversDns01AkamaiArgs>? Akamai { get; set; }

        /// <summary>
        /// Use the Microsoft Azure DNS API to manage DNS01 challenge records.
        /// </summary>
        [Input("azureDNS")]
        public Input<ClusterIssuerSpecAcmeSolversDns01AzureDNSArgs>? AzureDNS { get; set; }

        /// <summary>
        /// Use the Google Cloud DNS API to manage DNS01 challenge records.
        /// </summary>
        [Input("cloudDNS")]
        public Input<ClusterIssuerSpecAcmeSolversDns01CloudDNSArgs>? CloudDNS { get; set; }

        /// <summary>
        /// Use the Cloudflare API to manage DNS01 challenge records.
        /// </summary>
        [Input("cloudflare")]
        public Input<ClusterIssuerSpecAcmeSolversDns01CloudflareArgs>? Cloudflare { get; set; }

        /// <summary>
        /// CNAMEStrategy configures how the DNS01 provider should handle CNAME records when found in DNS zones.
        /// </summary>
        [Input("cnameStrategy")]
        public Input<string>? CnameStrategy { get; set; }

        /// <summary>
        /// Use the DigitalOcean DNS API to manage DNS01 challenge records.
        /// </summary>
        [Input("digitalocean")]
        public Input<ClusterIssuerSpecAcmeSolversDns01DigitaloceanArgs>? Digitalocean { get; set; }

        /// <summary>
        /// Use RFC2136 ("Dynamic Updates in the Domain Name System") (https://datatracker.ietf.org/doc/rfc2136/) to manage DNS01 challenge records.
        /// </summary>
        [Input("rfc2136")]
        public Input<ClusterIssuerSpecAcmeSolversDns01Rfc2136Args>? Rfc2136 { get; set; }

        /// <summary>
        /// Use the AWS Route53 API to manage DNS01 challenge records.
        /// </summary>
        [Input("route53")]
        public Input<ClusterIssuerSpecAcmeSolversDns01Route53Args>? Route53 { get; set; }

        /// <summary>
        /// Configure an external webhook based DNS01 challenge solver to manage DNS01 challenge records.
        /// </summary>
        [Input("webhook")]
        public Input<ClusterIssuerSpecAcmeSolversDns01WebhookArgs>? Webhook { get; set; }

        public ClusterIssuerSpecAcmeSolversDns01Args()
        {
        }
    }
}
