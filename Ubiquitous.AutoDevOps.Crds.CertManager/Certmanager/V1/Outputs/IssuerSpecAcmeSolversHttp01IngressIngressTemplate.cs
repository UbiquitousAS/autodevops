// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Outputs
{

    [OutputType]
    public sealed class IssuerSpecAcmeSolversHttp01IngressIngressTemplate
    {
        /// <summary>
        /// ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.
        /// </summary>
        public readonly IssuerSpecAcmeSolversHttp01IngressIngressTemplateMetadata Metadata;

        [OutputConstructor]
        private IssuerSpecAcmeSolversHttp01IngressIngressTemplate(IssuerSpecAcmeSolversHttp01IngressIngressTemplateMetadata metadata)
        {
            Metadata = metadata;
        }
    }
}
