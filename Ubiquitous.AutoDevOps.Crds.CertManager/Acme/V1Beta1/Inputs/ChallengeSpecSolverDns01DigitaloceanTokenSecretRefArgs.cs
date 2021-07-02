// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1Beta1.Inputs
{

    /// <summary>
    /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
    /// </summary>
    public class ChallengeSpecSolverDns01DigitaloceanTokenSecretRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ChallengeSpecSolverDns01DigitaloceanTokenSecretRefArgs()
        {
        }
    }
}
