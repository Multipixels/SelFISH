using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

    public string nextScene;

    public string nextLoadScene;

    public float waitTime;

    void FixedUpdate()
    {
        waitTime -= Time.deltaTime;

        if(waitTime <= 0)
        {
            Loading.nextScene = nextLoadScene;
            SceneManager.LoadScene(nextScene);
        }
    }
}
