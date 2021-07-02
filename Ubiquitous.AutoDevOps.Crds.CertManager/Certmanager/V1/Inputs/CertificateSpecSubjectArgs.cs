// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using Pulumi;

namespace Ubiquitous.AutoDevOps.Crds.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Full X509 name specification (https://golang.org/pkg/crypto/x509/pkix/#Name).
    /// </summary>
    public class CertificateSpecSubjectArgs : Pulumi.ResourceArgs
    {
        [Input("countries")]
        private InputList<string>? _countries;

        /// <summary>
        /// Countries to be used on the Certificate.
        /// </summary>
        public InputList<string> Countries
        {
            get => _countries ?? (_countries = new InputList<string>());
            set => _countries = value;
        }

        [Input("localities")]
        private InputList<string>? _localities;

        /// <summary>
        /// Cities to be used on the Certificate.
        /// </summary>
        public InputList<string> Localities
        {
            get => _localities ?? (_localities = new InputList<string>());
            set => _localities = value;
        }

        [Input("organizationalUnits")]
        private InputList<string>? _organizationalUnits;

        /// <summary>
        /// Organizational Units to be used on the Certificate.
        /// </summary>
        public InputList<string> OrganizationalUnits
        {
            get => _organizationalUnits ?? (_organizationalUnits = new InputList<string>());
            set => _organizationalUnits = value;
        }

        [Input("organizations")]
        private InputList<string>? _organizations;

        /// <summary>
        /// Organizations to be used on the Certificate.
        /// </summary>
        public InputList<string> Organizations
        {
            get => _organizations ?? (_organizations = new InputList<string>());
            set => _organizations = value;
        }

        [Input("postalCodes")]
        private InputList<string>? _postalCodes;

        /// <summary>
        /// Postal codes to be used on the Certificate.
        /// </summary>
        public InputList<string> PostalCodes
        {
            get => _postalCodes ?? (_postalCodes = new InputList<string>());
            set => _postalCodes = value;
        }

        [Input("provinces")]
        private InputList<string>? _provinces;

        /// <summary>
        /// State/Provinces to be used on the Certificate.
        /// </summary>
        public InputList<string> Provinces
        {
            get => _provinces ?? (_provinces = new InputList<string>());
            set => _provinces = value;
        }

        /// <summary>
        /// Serial number to be used on the Certificate.
        /// </summary>
        [Input("serialNumber")]
        public Input<string>? SerialNumber { get; set; }

        [Input("streetAddresses")]
        private InputList<string>? _streetAddresses;

        /// <summary>
        /// Street addresses to be used on the Certificate.
        /// </summary>
        public InputList<string> StreetAddresses
        {
            get => _streetAddresses ?? (_streetAddresses = new InputList<string>());
            set => _streetAddresses = value;
        }

        public CertificateSpecSubjectArgs()
        {
        }
    }
}
