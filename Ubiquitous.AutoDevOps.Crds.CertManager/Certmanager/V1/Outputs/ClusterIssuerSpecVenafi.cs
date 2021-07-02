// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Outputs
{

    [OutputType]
    public sealed class ClusterIssuerSpecVenafi
    {
        /// <summary>
        /// Cloud specifies the Venafi cloud configuration settings. Only one of TPP or Cloud may be specified.
        /// </summary>
        public readonly ClusterIssuerSpecVenafiCloud Cloud;
        /// <summary>
        /// TPP specifies Trust Protection Platform configuration settings. Only one of TPP or Cloud may be specified.
        /// </summary>
        public readonly ClusterIssuerSpecVenafiTpp Tpp;
        /// <summary>
        /// Zone is the Venafi Policy Zone to use for this issuer. All requests made to the Venafi platform will be restricted by the named zone policy. This field is required.
        /// </summary>
        public readonly string Zone;

        [OutputConstructor]
        private ClusterIssuerSpecVenafi(
            ClusterIssuerSpecVenafiCloud cloud,

            ClusterIssuerSpecVenafiTpp tpp,

            string zone)
        {
            Cloud = cloud;
            Tpp = tpp;
            Zone = zone;
        }
    }
}
