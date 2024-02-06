using Assets.Scripts.ComputerScript;
using UnityEngine;

namespace Assets.Scripts.PlayerControllers
{
    public class InteractionController: MonoBehaviour
    {
        [SerializeField] PlayerController playerController;
        private void Start()
        {
            
        }
        private void Update()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
            {
                if (hit.transform.CompareTag("Computer"))
                {
                    print("Compter in reach press E to interact");
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        ComputerScreen pcScreen = hit.transform.gameObject.GetComponent<ComputerScreen>();
                        playerController.disableMovement = true;
                        pcScreen.playerCam = GetComponent<Camera>();
                        pcScreen.playerController = playerController;
                        pcScreen.beingUsed = true;
                    }
                }
            }
        }
    }
}
