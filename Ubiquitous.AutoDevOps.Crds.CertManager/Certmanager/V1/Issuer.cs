// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using Pulumi;
using Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs;
using Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Outputs;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1 {
    /// <summary>
    /// An Issuer represents a certificate issuing authority which can be referenced as part of `issuerRef` fields. It is scoped to a single namespace and can therefore only be referenced by resources within the same namespace.
    /// </summary>
    public partial class Issuer : KubernetesResource {
        [Output("apiVersion")] public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")] public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Desired state of the Issuer resource.
        /// </summary>
        [Output("spec")]
        public Output<IssuerSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// Status of the Issuer. This is set and managed automatically.
        /// </summary>
        [Output("status")]
        public Output<IssuerStatus> Status { get; private set; } = null!;

        /// <summary>
        /// Create a Issuer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Issuer(string name, IssuerArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:cert-manager.io/v1:Issuer", name, MakeArgs(args), MakeResourceOptions(options, "")) { }

        internal Issuer(
            string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null
        )
            : base(
                "kubernetes:cert-manager.io/v1:Issuer",
                name,
                new DictionaryResourceArgs(dictionary),
                MakeResourceOptions(options, "")
            ) { }

        Issuer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:cert-manager.io/v1:Issuer", name, null, MakeResourceOptions(options, id)) { }

        static IssuerArgs? MakeArgs(IssuerArgs? args) {
            args            ??= new IssuerArgs();
            args.ApiVersion =   "cert-manager.io/v1";
            args.Kind       =   "Issuer";
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
        /// Get an existing Issuer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Issuer Get(string name, Input<string> id, CustomResourceOptions? options = null) {
            return new(name, id, options);
        }
    }

    public class IssuerArgs : ResourceArgs {
        [Input("apiVersion")] public Input<string>? ApiVersion { get; set; }

        [Input("kind")] public Input<string>? Kind { get; set; }

        [Input("metadata")] public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Desired state of the Issuer resource.
        /// </summary>
        [Input("spec")]
        public Input<IssuerSpecArgs>? Spec { get; set; }

        /// <summary>
        /// Status of the Issuer. This is set and managed automatically.
        /// </summary>
        [Input("status")]
        public Input<IssuerStatusArgs>? Status { get; set; }

        public IssuerArgs() { }
    }
}