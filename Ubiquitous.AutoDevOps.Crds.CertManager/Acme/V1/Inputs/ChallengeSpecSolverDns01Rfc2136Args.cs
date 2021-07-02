// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1.Inputs
{

    /// <summary>
    /// Use RFC2136 ("Dynamic Updates in the Domain Name System") (https://datatracker.ietf.org/doc/rfc2136/) to manage DNS01 challenge records.
    /// </summary>
    public class ChallengeSpecSolverDns01Rfc2136Args : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IP address or hostname of an authoritative DNS server supporting RFC2136 in the form host:port. If the host is an IPv6 address it must be enclosed in square brackets (e.g [2001:db8::1]) ; port is optional. This field is required.
        /// </summary>
        [Input("nameserver", required: true)]
        public Input<string> Nameserver { get; set; } = null!;

        /// <summary>
        /// The TSIG Algorithm configured in the DNS supporting RFC2136. Used only when ``tsigSecretSecretRef`` and ``tsigKeyName`` are defined. Supported values are (case-insensitive): ``HMACMD5`` (default), ``HMACSHA1``, ``HMACSHA256`` or ``HMACSHA512``.
        /// </summary>
        [Input("tsigAlgorithm")]
        public Input<string>? TsigAlgorithm { get; set; }

        /// <summary>
        /// The TSIG Key name configured in the DNS. If ``tsigSecretSecretRef`` is defined, this field is required.
        /// </summary>
        [Input("tsigKeyName")]
        public Input<string>? TsigKeyName { get; set; }

        /// <summary>
        /// The name of the secret containing the TSIG value. If ``tsigKeyName`` is defined, this field is required.
        /// </summary>
        [Input("tsigSecretSecretRef")]
        public Input<ChallengeSpecSolverDns01Rfc2136TsigSecretSecretRefArgs>? TsigSecretSecretRef { get; set; }

        public ChallengeSpecSolverDns01Rfc2136Args()
        {
        }
    }
}
