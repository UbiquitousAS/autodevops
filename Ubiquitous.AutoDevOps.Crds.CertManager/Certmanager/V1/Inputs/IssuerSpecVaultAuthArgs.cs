// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Auth configures how cert-manager authenticates with the Vault server.
    /// </summary>
    public class IssuerSpecVaultAuthArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AppRole authenticates with Vault using the App Role auth mechanism, with the role and secret stored in a Kubernetes Secret resource.
        /// </summary>
        [Input("appRole")]
        public Input<IssuerSpecVaultAuthAppRoleArgs>? AppRole { get; set; }

        /// <summary>
        /// Kubernetes authenticates with Vault by passing the ServiceAccount token stored in the named Secret resource to the Vault server.
        /// </summary>
        [Input("kubernetes")]
        public Input<IssuerSpecVaultAuthKubernetesArgs>? Kubernetes { get; set; }

        /// <summary>
        /// TokenSecretRef authenticates with Vault by presenting a token.
        /// </summary>
        [Input("tokenSecretRef")]
        public Input<IssuerSpecVaultAuthTokenSecretRefArgs>? TokenSecretRef { get; set; }

        public IssuerSpecVaultAuthArgs()
        {
        }
    }
}
