// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// TPP specifies Trust Protection Platform configuration settings. Only one of TPP or Cloud may be specified.
    /// </summary>
    public class ClusterIssuerSpecVenafiTppArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CABundle is a PEM encoded TLS certificate to use to verify connections to the TPP instance. If specified, system roots will not be used and the issuing CA for the TPP instance must be verifiable using the provided root. If not specified, the connection will be verified using the cert-manager system root certificates.
        /// </summary>
        [Input("caBundle")]
        public Input<string>? CaBundle { get; set; }

        /// <summary>
        /// CredentialsRef is a reference to a Secret containing the username and password for the TPP server. The secret must contain two keys, 'username' and 'password'.
        /// </summary>
        [Input("credentialsRef", required: true)]
        public Input<ClusterIssuerSpecVenafiTppCredentialsRefArgs> CredentialsRef { get; set; } = null!;

        /// <summary>
        /// URL is the base URL for the vedsdk endpoint of the Venafi TPP instance, for example: "https://tpp.example.com/vedsdk".
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public ClusterIssuerSpecVenafiTppArgs()
        {
        }
    }
}
