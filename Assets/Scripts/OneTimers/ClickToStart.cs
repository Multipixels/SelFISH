using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToStart : MonoBehaviour {

    public string nextScene;
    public string nextPauseScene;
	
	public void OnClick()
    {
        Loading.nextScene = nextPauseScene;
        SceneManager.LoadScene(nextScene);
    }
}
