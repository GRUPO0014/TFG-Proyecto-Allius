using UnityEngine;

[CreateAssetMenu(fileName = "New Grabbable Object", menuName = "ScriptableObjects/Interactable/GrabbableObjectSO")]   
public class GrabbableObjectSO : ScriptableObject
{
    public Transform prefab;
    public string objectName;
}
