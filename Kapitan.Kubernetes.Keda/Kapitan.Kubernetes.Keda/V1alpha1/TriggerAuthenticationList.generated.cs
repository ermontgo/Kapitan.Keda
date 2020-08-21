using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Keda.V1alpha1
{
    public partial class TriggerAuthenticationList : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "keda.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "TriggerAuthenticationList";

        /** <summary>List of triggerauthentications. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md</summary> */
        public List<Keda.V1alpha1.TriggerAuthentication> items { get; set; }
        /** <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary> */
        public object metadata { get; set; }
    }
}