// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1.Outputs
{

    [OutputType]
    public sealed class ChallengeSpecSolverHttp01Ingress
    {
        /// <summary>
        /// The ingress class to use when creating Ingress resources to solve ACME challenges that use this challenge solver. Only one of 'class' or 'name' may be specified.
        /// </summary>
        public readonly string Class;
        /// <summary>
        /// Optional ingress template used to configure the ACME challenge solver ingress used for HTTP01 challenges
        /// </summary>
        public readonly ChallengeSpecSolverHttp01IngressIngressTemplate IngressTemplate;
        /// <summary>
        /// The name of the ingress resource that should have ACME challenge solving routes inserted into it in order to solve HTTP01 challenges. This is typically used in conjunction with ingress controllers like ingress-gce, which maintains a 1:1 mapping between external IPs and ingress resources.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Optional pod template used to configure the ACME challenge solver pods used for HTTP01 challenges
        /// </summary>
        public readonly ChallengeSpecSolverHttp01IngressPodTemplate PodTemplate;
        /// <summary>
        /// Optional service type for Kubernetes solver service
        /// </summary>
        public readonly string ServiceType;

        [OutputConstructor]
        private ChallengeSpecSolverHttp01Ingress(
            string @class,

            ChallengeSpecSolverHttp01IngressIngressTemplate ingressTemplate,

            string name,

            ChallengeSpecSolverHttp01IngressPodTemplate podTemplate,

            string serviceType)
        {
            Class = @class;
            IngressTemplate = ingressTemplate;
            Name = name;
            PodTemplate = podTemplate;
            ServiceType = serviceType;
        }
    }
}
