using System.Collections.Generic;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;

namespace AutoDevOps.Resources {
    static class KubeNamespace {
        internal static Namespace Create(string name, Dictionary<string, string>? annotations) {
            // var existing = Namespace.Get(name);

            var namespaceAnnotations = (annotations ?? new Dictionary<string, string>())
                .AsInputMap();
            
            return new Namespace(
                name,
                new NamespaceArgs {
                    Metadata = new ObjectMetaArgs {
                        Name = name,
                        Annotations = namespaceAnnotations
                    },
                }
            );
        }
    }
}
