// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Acme.V1Beta1.Outputs
{

    [OutputType]
    public sealed class OrderStatusAuthorizations
    {
        /// <summary>
        /// Challenges specifies the challenge types offered by the ACME server. One of these challenge types will be selected when validating the DNS name and an appropriate Challenge resource will be created to perform the ACME challenge process.
        /// </summary>
        public readonly ImmutableArray<OrderStatusAuthorizationsChallenges> Challenges;
        /// <summary>
        /// Identifier is the DNS name to be validated as part of this authorization
        /// </summary>
        public readonly string Identifier;
        /// <summary>
        /// InitialState is the initial state of the ACME authorization when first fetched from the ACME server. If an Authorization is already 'valid', the Order controller will not create a Challenge resource for the authorization. This will occur when working with an ACME server that enables 'authz reuse' (such as Let's Encrypt's production endpoint). If not set and 'identifier' is set, the state is assumed to be pending and a Challenge will be created.
        /// </summary>
        public readonly string InitialState;
        /// <summary>
        /// URL is the URL of the Authorization that must be completed
        /// </summary>
        public readonly string Url;
        /// <summary>
        /// Wildcard will be true if this authorization is for a wildcard DNS name. If this is true, the identifier will be the *non-wildcard* version of the DNS name. For example, if '*.example.com' is the DNS name being validated, this field will be 'true' and the 'identifier' field will be 'example.com'.
        /// </summary>
        public readonly bool Wildcard;

        [OutputConstructor]
        private OrderStatusAuthorizations(
            ImmutableArray<OrderStatusAuthorizationsChallenges> challenges,

            string identifier,

            string initialState,

            string url,

            bool wildcard)
        {
            Challenges = challenges;
            Identifier = identifier;
            InitialState = initialState;
            Url = url;
            Wildcard = wildcard;
        }
    }
}
