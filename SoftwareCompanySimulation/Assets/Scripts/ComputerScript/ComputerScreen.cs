using UnityEngine;
using Assets.Scripts.PlayerControllers;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Assets.Scripts.ComputerScript
{
    public class ComputerScreen: MonoBehaviour
    {
        [SerializeField] LayerMask layer;
        [SerializeField] Transform camPos;

        Vector3 initialPos;

        public PlayerController playerController;
        public Camera playerCam;

        public GraphicRaycaster raycaster;
        PointerEventData pointerData;
        EventSystem eventSystem;

        private void Start()
        {
            raycaster = GetComponent<GraphicRaycaster>();
            eventSystem = GetComponent<EventSystem>();
        }

        private void Update()
        {
            if (playerCam != null)
            {
                UsePC();
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    ClosePC();
                }
            }
            
        }

        void UsePC()
        {
            Quaternion rotation = camPos.rotation;
            initialPos = playerCam.transform.localPosition;
            playerCam.transform.position = camPos.position;
            playerCam.transform.rotation = rotation;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;

        }

        void ClosePC()
        {
            playerCam.transform.localPosition = new Vector3(0,1.73f, 0);
            playerController.disableMovement = false;
            playerCam = null;
            //Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        public void OpenJobsPostal()
        {
            print("Displaying Job Postal");
        }
    }
}
