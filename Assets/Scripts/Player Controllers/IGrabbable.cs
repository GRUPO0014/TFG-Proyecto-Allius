using UnityEngine;

public interface IGrabbable 
{
    void OnGrab(IGrabbableObjectParent holder);
    void OnRelease();
    IGrabbableObjectParent GetCurrentHolder();
    void SetCurrentHolder(IGrabbableObjectParent holder);
    public GrabbableObjectSO GetGrabbableObjectSO();
    Transform GetTransform();
}
