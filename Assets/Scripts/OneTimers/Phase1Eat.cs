using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase1Eat : MonoBehaviour {

    public static float food;

    
    public GameObject cutsceneEnd;

    public Transform character;

	public void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.tag == "Food")
        {
            food += 1;
            character.transform.localScale += new Vector3(0, 0.05f, 0);
        }

        if(hit.tag == "Trap")
        {
            transform.Rotate(0, 0, 90);
            cutsceneEnd.SetActive(true);
        }
    }
}
