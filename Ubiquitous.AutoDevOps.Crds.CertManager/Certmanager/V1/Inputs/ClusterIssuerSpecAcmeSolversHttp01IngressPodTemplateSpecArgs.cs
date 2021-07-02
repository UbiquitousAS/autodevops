// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// PodSpec defines overrides for the HTTP01 challenge solver pod. Only the 'priorityClassName', 'nodeSelector', 'affinity', 'serviceAccountName' and 'tolerations' fields are supported currently. All other fields will be ignored.
    /// </summary>
    public class ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If specified, the pod's scheduling constraints
        /// </summary>
        [Input("affinity")]
        public Input<ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityArgs>? Affinity { get; set; }

        [Input("nodeSelector")]
        private InputMap<string>? _nodeSelector;

        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        public InputMap<string> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<string>());
            set => _nodeSelector = value;
        }

        /// <summary>
        /// If specified, the pod's priorityClassName.
        /// </summary>
        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        /// <summary>
        /// If specified, the pod's service account
        /// </summary>
        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        [Input("tolerations")]
        private InputList<ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecTolerationsArgs>? _tolerations;

        /// <summary>
        /// If specified, the pod's tolerations.
        /// </summary>
        public InputList<ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecTolerationsArgs>());
            set => _tolerations = value;
        }

        public ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecArgs()
        {
        }
    }
}
