using Unity.VisualScripting;
using UnityEngine;

public class ignora_assi : MonoBehaviour
{
    public bool ignoreXRotation = false;
    public bool ignoreYRotation = false;
    public bool ignoreZRotation = false;
    public bool limitRotation = false;
    public float maxRotation = 45f;

    private Quaternion initialRotation;
    //private Quaternion followRotation;
    public Transform resetRotation;
    private Vector3 eulerRotation;

    private void Start()
    {
        initialRotation = transform.rotation;
    }

    private void LateUpdate()

    {
        
        eulerRotation = transform.eulerAngles;

        if (ignoreXRotation)
            eulerRotation.x = initialRotation.eulerAngles.x;

        if (ignoreYRotation)
            eulerRotation.y = initialRotation.eulerAngles.y;

        if (ignoreZRotation)
            eulerRotation.z = initialRotation.eulerAngles.z;

        if(limitRotation){
            if(eulerRotation.y >= maxRotation && eulerRotation.y < 180)
            {
                eulerRotation.y = maxRotation;

            }else if (eulerRotation.y <= 315 && eulerRotation.y >= 180)
            {
                eulerRotation.y = 360-maxRotation;
            }
        transform.rotation = Quaternion.Euler(eulerRotation);
        }
    }

    public void ResetRotation()
    {
        
        transform.rotation = resetRotation.rotation;
           
    }
}