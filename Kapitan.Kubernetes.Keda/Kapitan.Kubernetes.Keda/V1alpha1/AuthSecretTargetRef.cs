﻿namespace Kapitan.Kubernetes.Keda.V1alpha1
{
    public class AuthSecretTargetRef
    {
        public string parameter { get; set; }
        public string name { get; set; }
        public string key { get; set; }
    }
}