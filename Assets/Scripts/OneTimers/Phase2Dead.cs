using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2Dead : MonoBehaviour {

    Collider2D karma;

	void OnTriggerEnter2D(Collider2D col)
    {
        karma = col;

        if(col.tag == "Dead")
        {
            Vector3 fishPosition = col.transform.position;
            fishPosition.y += 10f * Time.deltaTime;
            col.transform.position = fishPosition;
        }
    }
}