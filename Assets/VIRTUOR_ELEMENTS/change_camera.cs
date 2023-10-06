using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class change_camera : MonoBehaviour
{
    //This is Main Camera in the Scene
    Camera m_MainCamera;
    //This is the second Camera and is assigned in inspector
    public Camera m_CameraTwo;

    void Start()
    {
        //This gets the Main Camera from the Scene
        m_MainCamera = Camera.main;
        //This enables Main Camera
        m_MainCamera.enabled = true;
        m_MainCamera.GetComponent<TrackedPoseDriver>().enabled = true;
        //Use this to disable secondary Camera
        m_CameraTwo.enabled = false;
        m_CameraTwo.GetComponent<TrackedPoseDriver>().enabled = false;

    }

    void Update()
    {
        //Press the L Button to switch cameras
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Check that the Main Camera is enabled in the Scene, then switch to the other Camera on a key press
            if (m_MainCamera.enabled)
            {
                //Enable the second Camera
                m_CameraTwo.enabled = true;
                //m_CameraTwo.GetComponent<TrackedPoseDriver>().enabled = true;

                //The Main first Camera is disabled
                m_MainCamera.enabled = false;
                //m_MainCamera.GetComponent<TrackedPoseDriver>().enabled = false;

            }
            //Otherwise, if the Main Camera is not enabled, switch back to the Main Camera on a key press
            else if (!m_MainCamera.enabled)
            {
                //Disable the second camera
                m_CameraTwo.enabled = false;
                //m_CameraTwo.GetComponent<TrackedPoseDriver>().enabled = false;

                //Enable the Main Camera
                m_MainCamera.enabled = true;
                //m_MainCamera.GetComponent<TrackedPoseDriver>().enabled = true;

            }
        }
    }
}