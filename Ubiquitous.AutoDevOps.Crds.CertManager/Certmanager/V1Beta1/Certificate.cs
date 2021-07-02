// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using Pulumi;
using Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1Beta1.Inputs;
using Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1Beta1.Outputs;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1Beta1 {
    /// <summary>
    /// A Certificate resource should be created to ensure an up to date and signed x509 certificate is stored in the Kubernetes Secret resource named in `spec.secretName`.
    ///  The stored certificate will be renewed before it expires (as configured by `spec.renewBefore`).
    /// </summary>
    public partial class Certificate : KubernetesResource {
        [Output("apiVersion")] public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")] public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Desired state of the Certificate resource.
        /// </summary>
        [Output("spec")]
        public Output<CertificateSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// Status of the Certificate. This is set and managed automatically.
        /// </summary>
        [Output("status")]
        public Output<CertificateStatus> Status { get; private set; } = null!;

        /// <summary>
        /// Create a Certificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Certificate(string name, CertificateArgs? args = null, CustomResourceOptions? options = null)
            : base(
                "kubernetes:cert-manager.io/v1beta1:Certificate",
                name,
                MakeArgs(args),
                MakeResourceOptions(options, "")
            ) { }

        internal Certificate(
            string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null
        )
            : base(
                "kubernetes:cert-manager.io/v1beta1:Certificate",
                name,
                new DictionaryResourceArgs(dictionary),
                MakeResourceOptions(options, "")
            ) { }

        Certificate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:cert-manager.io/v1beta1:Certificate", name, null, MakeResourceOptions(options, id)) { }

        static CertificateArgs? MakeArgs(CertificateArgs? args) {
            args            ??= new CertificateArgs();
            args.ApiVersion =   "cert-manager.io/v1beta1";
            args.Kind       =   "Certificate";
            return args;
        }

        static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id) {
            var defaultOptions = new CustomResourceOptions {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }

        /// <summary>
        /// Get an existing Certificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Certificate Get(string name, Input<string> id, CustomResourceOptions? options = null) {
            return new(name, id, options);
        }
    }

    public class CertificateArgs : ResourceArgs {
        [Input("apiVersion")] public Input<string>? ApiVersion { get; set; }

        [Input("kind")] public Input<string>? Kind { get; set; }

        [Input("metadata")] public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Desired state of the Certificate resource.
        /// </summary>
        [Input("spec")]
        public Input<CertificateSpecArgs>? Spec { get; set; }

        /// <summary>
        /// Status of the Certificate. This is set and managed automatically.
        /// </summary>
        [Input("status")]
        public Input<CertificateStatusArgs>? Status { get; set; }

        public CertificateArgs() { }
    }
}