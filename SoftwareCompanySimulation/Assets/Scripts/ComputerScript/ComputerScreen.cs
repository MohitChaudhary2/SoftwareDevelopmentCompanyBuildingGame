using UnityEngine;
using Assets.Scripts.PlayerControllers;

namespace Assets.Scripts.ComputerScript
{
    public class ComputerScreen: MonoBehaviour
    {
        [SerializeField] Camera screenCam;

        private Vector3 initialPlayerCamPos;

        public bool beingUsed = false;
        public PlayerController playerController;
        public Camera playerCam;
        private void Start()
        {
            screenCam = GetComponentInChildren<Camera>();
        }

        private void Update()
        {
            if (!beingUsed)
            {
                screenCam.enabled = false;
            }
            else
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
            screenCam.enabled = true;
            playerCam.enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        void ClosePC()
        {
            beingUsed = false;
            screenCam.enabled = false;
            playerCam.enabled = true;
            playerController.disableMovement = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
