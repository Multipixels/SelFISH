using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurnOff : MonoBehaviour {

    public float disable;

    public GameObject turnThisOff;

    void FixedUpdate()
    {
        disable -= Time.deltaTime;

        if(disable <= 0)
        {
            turnThisOff.SetActive(false);
        }
    }
}
