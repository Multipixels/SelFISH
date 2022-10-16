using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

    public static string nextScene;

    public float loadingTime = 5f;
	
    void FixedUpdate()
    {
        loadingTime -= Time.deltaTime;

        if(loadingTime <= 0)
        {
            Load();
        }
    }

	public void Load()
    {
        SceneManager.LoadScene(nextScene);
    }
}
