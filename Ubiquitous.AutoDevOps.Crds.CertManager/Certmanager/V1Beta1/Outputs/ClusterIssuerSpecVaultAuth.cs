// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1Beta1.Outputs
{

    [OutputType]
    public sealed class ClusterIssuerSpecVaultAuth
    {
        /// <summary>
        /// AppRole authenticates with Vault using the App Role auth mechanism, with the role and secret stored in a Kubernetes Secret resource.
        /// </summary>
        public readonly ClusterIssuerSpecVaultAuthAppRole AppRole;
        /// <summary>
        /// Kubernetes authenticates with Vault by passing the ServiceAccount token stored in the named Secret resource to the Vault server.
        /// </summary>
        public readonly ClusterIssuerSpecVaultAuthKubernetes Kubernetes;
        /// <summary>
        /// TokenSecretRef authenticates with Vault by presenting a token.
        /// </summary>
        public readonly ClusterIssuerSpecVaultAuthTokenSecretRef TokenSecretRef;

        [OutputConstructor]
        private ClusterIssuerSpecVaultAuth(
            ClusterIssuerSpecVaultAuthAppRole appRole,

            ClusterIssuerSpecVaultAuthKubernetes kubernetes,

            ClusterIssuerSpecVaultAuthTokenSecretRef tokenSecretRef)
        {
            AppRole = appRole;
            Kubernetes = kubernetes;
            TokenSecretRef = tokenSecretRef;
        }
    }
}
