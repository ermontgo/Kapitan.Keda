using System.Collections;
using System.Collections.Generic;

namespace Kapitan.Kubernetes.Keda.V1alpha1
{
    public class HashiCorpVault
    {
        public string address { get; set; }
        public string authentication { get; set; }
        public IEnumerable<VaultSecret> secrets { get; set; }
        public Credential credential { get; set; }
        public string role { get; set; }
        public string mount { get; set; }
    }
}