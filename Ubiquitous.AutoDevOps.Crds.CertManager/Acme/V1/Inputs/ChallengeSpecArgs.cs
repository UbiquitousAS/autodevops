// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1.Inputs
{

    public class ChallengeSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL to the ACME Authorization resource that this challenge is a part of.
        /// </summary>
        [Input("authorizationURL", required: true)]
        public Input<string> AuthorizationURL { get; set; } = null!;

        /// <summary>
        /// dnsName is the identifier that this challenge is for, e.g. example.com. If the requested DNSName is a 'wildcard', this field MUST be set to the non-wildcard domain, e.g. for `*.example.com`, it must be `example.com`.
        /// </summary>
        [Input("dnsName", required: true)]
        public Input<string> DnsName { get; set; } = null!;

        /// <summary>
        /// References a properly configured ACME-type Issuer which should be used to create this Challenge. If the Issuer does not exist, processing will be retried. If the Issuer is not an 'ACME' Issuer, an error will be returned and the Challenge will be marked as failed.
        /// </summary>
        [Input("issuerRef", required: true)]
        public Input<ChallengeSpecIssuerRefArgs> IssuerRef { get; set; } = null!;

        /// <summary>
        /// The ACME challenge key for this challenge For HTTP01 challenges, this is the value that must be responded with to complete the HTTP01 challenge in the format: `&lt;private key JWK thumbprint&gt;.&lt;key from acme server for challenge&gt;`. For DNS01 challenges, this is the base64 encoded SHA256 sum of the `&lt;private key JWK thumbprint&gt;.&lt;key from acme server for challenge&gt;` text that must be set as the TXT record content.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Contains the domain solving configuration that should be used to solve this challenge resource.
        /// </summary>
        [Input("solver", required: true)]
        public Input<ChallengeSpecSolverArgs> Solver { get; set; } = null!;

        /// <summary>
        /// The ACME challenge token for this challenge. This is the raw value returned from the ACME server.
        /// </summary>
        [Input("token", required: true)]
        public Input<string> Token { get; set; } = null!;

        /// <summary>
        /// The type of ACME challenge this resource represents. One of "HTTP-01" or "DNS-01".
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The URL of the ACME Challenge resource for this challenge. This can be used to lookup details about the status of this challenge.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        /// <summary>
        /// wildcard will be true if this challenge is for a wildcard identifier, for example '*.example.com'.
        /// </summary>
        [Input("wildcard")]
        public Input<bool>? Wildcard { get; set; }

        public ChallengeSpecArgs()
        {
        }
    }
}
