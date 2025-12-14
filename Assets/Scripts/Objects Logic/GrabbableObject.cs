using StarterAssets;
using UnityEngine;

public class GrabbableObject : MonoBehaviour, IInteractable, IGrabbable
{
    [SerializeField] private GrabbableObjectSO grabbableObjectSO;
    [SerializeField] private Collider objectCollider;
    private bool isGrabbed = false;
    private IGrabbableObjectParent currentHolder;

    public IGrabbableObjectParent GetCurrentHolder()
    {
        return currentHolder;
    }

    public GrabbableObjectSO GetGrabbableObjectSO()
    {
        return grabbableObjectSO;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    public void Interact(Transform interactorTransform)
    {
        OnGrab(interactorTransform.GetComponent<IGrabbableObjectParent>());        
    }

    public void OnGrab(IGrabbableObjectParent holder)
    {
        if (isGrabbed) return;

        isGrabbed = true;        
        SetCurrentHolder(holder);                                                             
    }

    public void OnRelease()
    {
        if (!isGrabbed) return;
        Debug.Log("OnReleasing object");
        isGrabbed = false;
        if (TryGetComponent<Rigidbody>(out var rb))
            rb.isKinematic = false;        
        transform.parent = null;
        currentHolder.ClearHeldObject();
        currentHolder = null;
        objectCollider.enabled = true;
    }

    public void SetCurrentHolder(IGrabbableObjectParent holder)
    {
        currentHolder = holder;
        if (TryGetComponent<Rigidbody>(out var rb))
            rb.isKinematic = true;  
        transform.parent = holder.GetObjectHoldPoint();
        transform.localPosition = Vector3.zero;
        currentHolder.SetHeldObject(transform);
        objectCollider.enabled = false;
    }
}
