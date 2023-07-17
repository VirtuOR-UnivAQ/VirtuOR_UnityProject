using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Rotate_rig_prova : MonoBehaviour
{

    Quaternion riferimento;

    [SerializeField]
        [Tooltip("xrorigin da controllare")]
        GameObject m_xrrig;

    public GameObject xrorig
    {
        get => m_xrrig;
        set => m_xrrig = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        riferimento = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rotate_rig()
    {
        m_xrrig.transform.rotation = riferimento;
    }
}
