using UnityEngine;
using UnityEngine.Events;

public class MoveObjectAtPosition : MonoBehaviour
{
    public void MoveObject(Transform targetPosition)
    {
        gameObject.transform.position = targetPosition.position;
    }
}
