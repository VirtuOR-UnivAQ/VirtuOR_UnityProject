using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class resetInitialRotation : MonoBehaviour
{
    //public Transform resetRotation;
    public Quaternion resetRotation;

    private void Start()
    {
        
    }

    public void ResetRotation()
    {
        
        transform.rotation = resetRotation;
           
    }
}