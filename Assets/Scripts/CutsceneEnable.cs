using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneEnable : MonoBehaviour {

    public static bool cutsceneEnabled = false;

    public GameObject cutscene;

    void Update()
    {
        if(cutscene.activeSelf == false)
        {
            cutsceneEnabled = false;
        } else
        {
            cutsceneEnabled = true;
        }
    }
}
