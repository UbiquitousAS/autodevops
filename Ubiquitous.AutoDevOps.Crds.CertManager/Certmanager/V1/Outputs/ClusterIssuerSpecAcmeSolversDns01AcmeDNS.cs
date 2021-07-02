// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Outputs
{

    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversDns01AcmeDNS
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ClusterIssuerSpecAcmeSolversDns01AcmeDNSAccountSecretRef AccountSecretRef;
        public readonly string Host;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversDns01AcmeDNS(
            ClusterIssuerSpecAcmeSolversDns01AcmeDNSAccountSecretRef accountSecretRef,

            string host)
        {
            AccountSecretRef = accountSecretRef;
            Host = host;
        }
    }
}
