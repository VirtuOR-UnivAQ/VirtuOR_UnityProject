using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneController : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject loadingMenu;
    public Slider loadingBar;
	public TMP_Text loadPromptText;
	public TMP_Text loadText;
	public KeyCode userPromptKey;
	public bool waitForInput = true;


    // Start is called before the first frame update
    void Start()
    {

    }

	// Awake is called before the start
    void Awake()
    {
		DontDestroyOnLoad(this.gameObject);
		Debug.Log("Awake: " + this.gameObject);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string scene){
		if(scene != ""){
			StartCoroutine(LoadAsynchronously(scene));
		}
	}

    IEnumerator LoadAsynchronously(string sceneName){ // scene name is just the name of the current scene being loaded
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
		operation.allowSceneActivation = false;
		mainCanvas.SetActive(false);
		loadingMenu.SetActive(true);

		while (!operation.isDone){
			float progress = Mathf.Clamp01(operation.progress / .95f);
			loadingBar.value = progress;

			if (operation.progress >= 0.9f && waitForInput){
				loadPromptText.text = "Premi il tasto " + userPromptKey.ToString().ToUpper() + " per entrare nel mondo virtuale!";
				loadingBar.value = 1;
				loadText.text = "Caricamento completato!";

				if (Input.GetKeyDown(userPromptKey)){
					operation.allowSceneActivation = true;
				}
            }else if(operation.progress >= 0.9f && !waitForInput){
					operation.allowSceneActivation = true;
			}
			yield return null;
		}
	}
}
