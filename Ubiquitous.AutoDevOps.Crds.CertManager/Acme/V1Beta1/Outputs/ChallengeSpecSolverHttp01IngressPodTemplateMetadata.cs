// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1Beta1.Outputs
{

    [OutputType]
    public sealed class ChallengeSpecSolverHttp01IngressPodTemplateMetadata
    {
        /// <summary>
        /// Annotations that should be added to the create ACME HTTP01 solver pods.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// Labels that should be added to the created ACME HTTP01 solver pods.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;

        [OutputConstructor]
        private ChallengeSpecSolverHttp01IngressPodTemplateMetadata(
            ImmutableDictionary<string, string> annotations,

            ImmutableDictionary<string, string> labels)
        {
            Annotations = annotations;
            Labels = labels;
        }
    }
}
