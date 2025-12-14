using UnityEngine;

public class CS_FlashlightController : MonoBehaviour
{ 
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Transform flashlight;
    //private InputSystem_Actions input;  

    void LateUpdate()
    {        
        flashlight.rotation = playerCamera.transform.rotation;
    }     

}
