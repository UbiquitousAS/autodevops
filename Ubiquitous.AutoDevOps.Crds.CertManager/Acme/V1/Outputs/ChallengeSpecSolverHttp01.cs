// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1.Outputs
{

    [OutputType]
    public sealed class ChallengeSpecSolverHttp01
    {
        /// <summary>
        /// The ingress based HTTP01 challenge solver will solve challenges by creating or modifying Ingress resources in order to route requests for '/.well-known/acme-challenge/XYZ' to 'challenge solver' pods that are provisioned by cert-manager for each Challenge to be completed.
        /// </summary>
        public readonly ChallengeSpecSolverHttp01Ingress Ingress;

        [OutputConstructor]
        private ChallengeSpecSolverHttp01(ChallengeSpecSolverHttp01Ingress ingress)
        {
            Ingress = ingress;
        }
    }
}
