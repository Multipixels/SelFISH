using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour {



	void OnTriggerEnter2D()
    {
        if(this.tag == "Food")
        {
            FoodSpawn.foodEaten++;
        }

        Destroy(gameObject);
    }
}
