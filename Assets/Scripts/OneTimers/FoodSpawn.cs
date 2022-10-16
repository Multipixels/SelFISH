using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FoodSpawn : MonoBehaviour {

    public static float foodEaten;

    public GameObject food;
    public GameObject trap;

    public Text foodCounter;

    public float delayTimer = 2;
    public float delay = 3f;

    public float amountOfFoodSpawned = 0;

	void FixedUpdate () {

        foodCounter.text = "Food Stored: " + foodEaten;

        if (CutsceneEnable.cutsceneEnabled == false)
        {
            delayTimer -= Time.deltaTime;
        }

        if(delayTimer <= 0)
        {
            Vector3 foodPosition = transform.position;

            if (amountOfFoodSpawned == 10)
            {
                amountOfFoodSpawned++;

                Vector3 trapPosition = foodPosition;

                trapPosition.x = Random.Range(-4, 4);
                trapPosition.y = 4.5f;

                Instantiate(trap, trapPosition, transform.rotation);
            }
            else if (amountOfFoodSpawned != 10)
            {
                amountOfFoodSpawned++;
                delayTimer = delay;

                foodPosition.x = Random.Range(-4, 4);
                foodPosition.y = Random.Range(-4, 4);

                Instantiate(food, foodPosition, transform.rotation);
            }
        }
	}
}
