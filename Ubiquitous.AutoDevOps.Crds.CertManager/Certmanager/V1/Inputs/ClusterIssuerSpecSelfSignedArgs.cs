// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// SelfSigned configures this issuer to 'self sign' certificates using the private key used to create the CertificateRequest object.
    /// </summary>
    public class ClusterIssuerSpecSelfSignedArgs : Pulumi.ResourceArgs
    {
        [Input("crlDistributionPoints")]
        private InputList<string>? _crlDistributionPoints;

        /// <summary>
        /// The CRL distribution points is an X.509 v3 certificate extension which identifies the location of the CRL from which the revocation of this certificate can be checked. If not set certificate will be issued without CDP. Values are strings.
        /// </summary>
        public InputList<string> CrlDistributionPoints
        {
            get => _crlDistributionPoints ?? (_crlDistributionPoints = new InputList<string>());
            set => _crlDistributionPoints = value;
        }

        public ClusterIssuerSpecSelfSignedArgs()
        {
        }
    }
}
