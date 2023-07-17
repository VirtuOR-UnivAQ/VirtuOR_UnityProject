using UnityEngine;

public class ignora_assi : MonoBehaviour
{
    public bool ignoreXRotation = false;
    public bool ignoreYRotation = false;
    public bool ignoreZRotation = false;
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

        if(eulerRotation.y > 45f || eulerRotation.y < -45f)
        {
            eulerRotation.y = 45f;
        }
        transform.rotation = Quaternion.Euler(eulerRotation);
    }

    public void ResetRotation()
    {
        
        transform.rotation = resetRotation.rotation;
           
    }
}