using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject exitMenuGameObject;
    // Start is called before the first frame update
    public InputActionAsset inputActionAsset;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

            if(exitMenuGameObject.activeSelf){
                if (inputActionAsset.FindAction("Submit").WasReleasedThisFrame()){
                    ExitMenu();
                    } else if (inputActionAsset.FindAction("ExitMenu").WasReleasedThisFrame()){
                    exitMenuGameObject.SetActive(false);
                    }
            } else {
                if (inputActionAsset.FindAction("ExitMenu").WasReleasedThisFrame()){
                    exitMenuGameObject.SetActive(true);
                    Debug.Log("A button on gamepad was released this frame");}

            }


    }
    void ExitMenu()
    {
            #if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
			#else
				//Application.Quit();
                Debug.Log("A button on gamepad was released this frame");}

                UIMenuManager.LoadScene("Demo1");
                //GameObject.LoadScene("Demo1");
			#endif
        }

}