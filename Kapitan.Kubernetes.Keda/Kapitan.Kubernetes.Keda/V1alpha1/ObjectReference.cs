namespace Kapitan.Kubernetes.Keda.V1alpha1
{
    public class ObjectReference
    {
        public string deploymentName { get; set; }
        public string containerName { get; set; }
    }
}