using System.Collections;
using System.Collections.Generic;

namespace Kapitan.Kubernetes.Keda.V1alpha1
{
    public class TriggerAuthenticationSpec
    {
        public AuthPodIdentity podIdentity { get; set; }
        public IEnumerable<AuthSecretTargetRef> secretTargetRef { get; set; }
        public IEnumerable<AuthEnvironment> env { get; set; }
        public HashiCorpVault hashiCorpVault { get; set; }
    }
}