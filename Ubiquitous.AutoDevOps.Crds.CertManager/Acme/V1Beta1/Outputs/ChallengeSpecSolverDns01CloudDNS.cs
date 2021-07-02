// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1Beta1.Outputs
{

    [OutputType]
    public sealed class ChallengeSpecSolverDns01CloudDNS
    {
        /// <summary>
        /// HostedZoneName is an optional field that tells cert-manager in which Cloud DNS zone the challenge record has to be created. If left empty cert-manager will automatically choose a zone.
        /// </summary>
        public readonly string HostedZoneName;
        public readonly string Project;
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ChallengeSpecSolverDns01CloudDNSServiceAccountSecretRef ServiceAccountSecretRef;

        [OutputConstructor]
        private ChallengeSpecSolverDns01CloudDNS(
            string hostedZoneName,

            string project,

            ChallengeSpecSolverDns01CloudDNSServiceAccountSecretRef serviceAccountSecretRef)
        {
            HostedZoneName = hostedZoneName;
            Project = project;
            ServiceAccountSecretRef = serviceAccountSecretRef;
        }
    }
}
