using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ProjectManager
{
    public class ProjectSelectionManager : MonoBehaviour
    {
        public GameObject projectButtonPrefab;
        public Transform buttonContainer;

        public ProjectType[] projectTypes;

        void Start()
        {
            InitializeProjectButtons();
        }

        void InitializeProjectButtons()
        {
            foreach (ProjectType projectType in projectTypes)
            {
                GameObject buttonGO = Instantiate(projectButtonPrefab, buttonContainer);
                ProjectButton projectButton = buttonGO.GetComponent<ProjectButton>();
                projectButton.Initialize(projectType);
            }
        }
    }

}
