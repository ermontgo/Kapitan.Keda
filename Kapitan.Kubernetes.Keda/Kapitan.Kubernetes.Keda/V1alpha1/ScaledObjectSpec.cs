using Kapitan.Kubernetes.Batch.V1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Kubernetes.Keda.V1alpha1
{
    public class ScaledObjectSpec
    {
        public string scaleType { get; set; }
        public ObjectReference scaleTargetRef { get; set; }
        public JobSpec jobTargetRef { get; set; }
        public int pollingInterval { get; set; }
        public int cooldownPeriod { get; set; }
        public int minReplicaCount { get; set; }
        public int maxReplicaCount { get; set; }

        public IEnumerable<object> triggers { get; set; }
    }
}
