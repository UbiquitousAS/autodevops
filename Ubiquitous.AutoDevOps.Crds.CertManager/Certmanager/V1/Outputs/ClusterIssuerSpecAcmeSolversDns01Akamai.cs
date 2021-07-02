// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Outputs
{

    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversDns01Akamai
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ClusterIssuerSpecAcmeSolversDns01AkamaiAccessTokenSecretRef AccessTokenSecretRef;
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ClusterIssuerSpecAcmeSolversDns01AkamaiClientSecretSecretRef ClientSecretSecretRef;
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ClusterIssuerSpecAcmeSolversDns01AkamaiClientTokenSecretRef ClientTokenSecretRef;
        public readonly string ServiceConsumerDomain;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversDns01Akamai(
            ClusterIssuerSpecAcmeSolversDns01AkamaiAccessTokenSecretRef accessTokenSecretRef,

            ClusterIssuerSpecAcmeSolversDns01AkamaiClientSecretSecretRef clientSecretSecretRef,

            ClusterIssuerSpecAcmeSolversDns01AkamaiClientTokenSecretRef clientTokenSecretRef,

            string serviceConsumerDomain)
        {
            AccessTokenSecretRef = accessTokenSecretRef;
            ClientSecretSecretRef = clientSecretSecretRef;
            ClientTokenSecretRef = clientTokenSecretRef;
            ServiceConsumerDomain = serviceConsumerDomain;
        }
    }
}
