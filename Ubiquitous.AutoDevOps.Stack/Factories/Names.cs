using static Ubiquitous.AutoDevOps.Stack.AutoDevOpsSettings;

namespace Ubiquitous.AutoDevOps.Stack.Factories {
    public static class Names {
        public static string PulumiName(this DeploySettings settings, string? resource = null) => 
            resource.IsEmpty() ? settings.ResourceName : $"{settings.ResourceName}-{resource}";
    }
}