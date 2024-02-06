using UnityEngine;
namespace Assets.Scripts.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Project Type", menuName = "Project Type")]
    public class ProjectType: ScriptableObject
    {
        public string typeName;
        public string description;

        public float timeToComplete;
        public int profit;
        // Add more properties as needed
    }
}
