using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    public string sceneToLoad;
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey) {
            OpenNextScene();
        }
	}

    private void OpenNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
