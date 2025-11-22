using UnityEngine;

public class CS_FlashlightController : MonoBehaviour
{ 
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Transform flashlight;
    //private InputSystem_Actions input;  

    void Update()
    {        
        flashlight.rotation = Quaternion.LookRotation(playerCamera.transform.forward);
    }
     

   /* private void Awake()
    {
        input = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        input.Player.Enable();
        input.Player.ToggleFlashlight.performed += ToggleFlashlight;
    }

    private void OnDisable()
    {
        input.Player.ToggleFlashlight.performed -= ToggleFlashlight;
        input.Player.Disable();
    }

    private void ToggleFlashlight(InputAction.CallbackContext ctx)
    {
        flashlight.gameObject.SetActive(!flashlight.gameObject.activeSelf);
    }*/

}
