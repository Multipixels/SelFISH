using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public float gravity;

    Vector3 pos;

    public GameObject cutScene;

    void Start()
    {
        pos = transform.position;
    }

	// Update is called once per frame
	void Update () {

        pos = transform.position;

        gravity -= 0.0001f;

        if (CutsceneEnable.cutsceneEnabled == false)
        {
            if (pos.y >= -3.36)
            {
                pos.y -= gravity * Time.deltaTime;
                transform.position = pos;
            }

            if (pos.y >= 5.5)
            {
                cutScene.SetActive(true);
            }
        }
	}

    void OnTriggerEnter2D()
    {
        pos.y += 0.5f;
        transform.position = pos;
    }
}
