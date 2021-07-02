// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1Beta1.Inputs
{

    /// <summary>
    /// CA configures this issuer to sign certificates using a signing CA keypair stored in a Secret resource. This is used to build internal PKIs that are managed by cert-manager.
    /// </summary>
    public class IssuerSpecCaArgs : Pulumi.ResourceArgs
    {
        [Input("crlDistributionPoints")]
        private InputList<string>? _crlDistributionPoints;

        /// <summary>
        /// The CRL distribution points is an X.509 v3 certificate extension which identifies the location of the CRL from which the revocation of this certificate can be checked. If not set, certificates will be issued without distribution points set.
        /// </summary>
        public InputList<string> CrlDistributionPoints
        {
            get => _crlDistributionPoints ?? (_crlDistributionPoints = new InputList<string>());
            set => _crlDistributionPoints = value;
        }

        [Input("ocspServers")]
        private InputList<string>? _ocspServers;

        /// <summary>
        /// The OCSP server list is an X.509 v3 extension that defines a list of URLs of OCSP responders. The OCSP responders can be queried for the revocation status of an issued certificate. If not set, the certificate will be issued with no OCSP servers set. For example, an OCSP server URL could be "http://ocsp.int-x3.letsencrypt.org".
        /// </summary>
        public InputList<string> OcspServers
        {
            get => _ocspServers ?? (_ocspServers = new InputList<string>());
            set => _ocspServers = value;
        }

        /// <summary>
        /// SecretName is the name of the secret used to sign Certificates issued by this Issuer.
        /// </summary>
        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        public IssuerSpecCaArgs()
        {
        }
    }
}
