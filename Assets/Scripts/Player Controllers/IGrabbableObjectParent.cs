using UnityEngine;

public interface IGrabbableObjectParent 
{
    public Transform GetObjectHoldPoint();
    public void SetHeldObject(Transform heldObject);
    public IGrabbable GetGrabbableObject();
    public void ClearHeldObject();
    public bool HasHeldObject();    
    
}

