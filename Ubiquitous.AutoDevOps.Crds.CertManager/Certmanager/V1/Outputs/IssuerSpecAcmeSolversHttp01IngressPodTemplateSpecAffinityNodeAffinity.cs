// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Outputs
{

    [OutputType]
    public sealed class IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity
    {
        /// <summary>
        /// The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
        /// </summary>
        public readonly ImmutableArray<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution> PreferredDuringSchedulingIgnoredDuringExecution;
        /// <summary>
        /// If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
        /// </summary>
        public readonly IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution RequiredDuringSchedulingIgnoredDuringExecution;

        [OutputConstructor]
        private IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity(
            ImmutableArray<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution> preferredDuringSchedulingIgnoredDuringExecution,

            IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution requiredDuringSchedulingIgnoredDuringExecution)
        {
            PreferredDuringSchedulingIgnoredDuringExecution = preferredDuringSchedulingIgnoredDuringExecution;
            RequiredDuringSchedulingIgnoredDuringExecution = requiredDuringSchedulingIgnoredDuringExecution;
        }
    }
}
