// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1Beta1.Outputs
{

    [OutputType]
    public sealed class ClusterIssuerSpecVenafiTppCredentialsRef
    {
        /// <summary>
        /// Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ClusterIssuerSpecVenafiTppCredentialsRef(string name)
        {
            Name = name;
        }
    }
}
