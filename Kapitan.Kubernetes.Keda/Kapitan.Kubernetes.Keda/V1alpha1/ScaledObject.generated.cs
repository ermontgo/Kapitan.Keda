using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes.Batch.V1;

namespace Kapitan.Kubernetes.Keda.V1alpha1
{
    public partial class ScaledObject : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "keda.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "ScaledObject";
    }

    
}