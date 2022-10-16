using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextJoke : MonoBehaviour {

    public float month1 = 0f;
    public float week2 = 3f;
    public float week1 = 6f;
    public float day1 = 9f;
    public float hour1 = 12f;
    public float minutes10 = 15f;

    public Text joke;

	// Update is called once per frame
	void Update () {

        week2 -= Time.deltaTime;
        week1 -= Time.deltaTime;
        day1 -= Time.deltaTime;
        hour1 -= Time.deltaTime;
        minutes10 -= Time.deltaTime;

		if(month1 <= 0)
        {
            joke.text = "1 Month Later...";
        }

        if (week2 <= 0)
        {
            joke.text = "Wait no... 2 Weeks Later...";
        }

        if (week1 <= 0)
        {
            joke.text = "What? I said the wrong line? Fine... 1 Week Later...";
        }

        if (day1 <= 0)
        {
            joke.text = "What do you mean... 1 Day Later...";
        }

        if (hour1 <= 0)
        {
            joke.text = "I give up this job, can someone else take it? 1 Hour Later...";
        }

        if (minutes10 <= 0)
        {
            joke.text = "Just let me do it correctly... 10 Minutes Later...";
        }
    }
}
