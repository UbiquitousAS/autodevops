// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Use the Microsoft Azure DNS API to manage DNS01 challenge records.
    /// </summary>
    public class IssuerSpecAcmeSolversDns01AzureDNSArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// if both this and ClientSecret are left unset MSI will be used
        /// </summary>
        [Input("clientID")]
        public Input<string>? ClientID { get; set; }

        /// <summary>
        /// if both this and ClientID are left unset MSI will be used
        /// </summary>
        [Input("clientSecretSecretRef")]
        public Input<IssuerSpecAcmeSolversDns01AzureDNSClientSecretSecretRefArgs>? ClientSecretSecretRef { get; set; }

        [Input("environment")]
        public Input<string>? Environment { get; set; }

        [Input("hostedZoneName")]
        public Input<string>? HostedZoneName { get; set; }

        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("subscriptionID", required: true)]
        public Input<string> SubscriptionID { get; set; } = null!;

        /// <summary>
        /// when specifying ClientID and ClientSecret then this field is also needed
        /// </summary>
        [Input("tenantID")]
        public Input<string>? TenantID { get; set; }

        public IssuerSpecAcmeSolversDns01AzureDNSArgs()
        {
        }
    }
}
