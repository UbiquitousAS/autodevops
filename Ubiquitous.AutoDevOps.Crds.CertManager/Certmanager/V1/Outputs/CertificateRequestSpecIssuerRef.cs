// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Outputs
{

    [OutputType]
    public sealed class CertificateRequestSpecIssuerRef
    {
        /// <summary>
        /// Group of the resource being referred to.
        /// </summary>
        public readonly string Group;
        /// <summary>
        /// Kind of the resource being referred to.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the resource being referred to.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private CertificateRequestSpecIssuerRef(
            string group,

            string kind,

            string name)
        {
            Group = group;
            Kind = kind;
            Name = name;
        }
    }
}
