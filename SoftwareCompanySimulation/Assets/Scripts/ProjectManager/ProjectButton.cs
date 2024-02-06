using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ProjectManager
{
    

    public class ProjectButton : MonoBehaviour
    {
        public Text nameLabel;
        public Text descriptionLabel;
        public Text price;
        public Text time;

        private ProjectType projectType;

        public void Initialize(ProjectType projectType)
        {
            this.projectType = projectType;
            nameLabel.text = projectType.typeName;
            descriptionLabel.text = projectType.description;
            price.text = projectType.profit.ToString();
            time.text = projectType.timeToComplete.ToString();
        }

        public void OnClick()
        {
            // Add logic to handle project selection
            Debug.Log("Selected project: " + projectType.typeName);
            // Display detailed information or confirm selection
        }
    }

}
