// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1Beta1.Outputs
{

    [OutputType]
    public sealed class CertificateRequestStatusConditions
    {
        /// <summary>
        /// LastTransitionTime is the timestamp corresponding to the last status change of this condition.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// Message is a human readable description of the details of the last transition, complementing reason.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Reason is a brief machine readable explanation for the condition's last transition.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Status of the condition, one of (`True`, `False`, `Unknown`).
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of the condition, known values are (`Ready`, `InvalidRequest`, `Approved`, `Denied`).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private CertificateRequestStatusConditions(
            string lastTransitionTime,

            string message,

            string reason,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
