using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 8;

    public SpriteRenderer character;

	// Update is called once per frame
	void Update () {
        Vector3 characterPos = transform.position;

        if (CutsceneEnable.cutsceneEnabled == false)
        {

            if (Input.GetAxis("A") >= 0.01)
            {
                characterPos.x += -speed * Time.deltaTime;
                character.flipX = true;
            }
            if (Input.GetAxis("D") >= 0.01)
            {
                characterPos.x += speed * Time.deltaTime;
                character.flipX = false;
            }
            if (Input.GetAxis("W") >= 0.01)
            {
                characterPos.y += (speed / 1.75f) * Time.deltaTime;
            }
            if (Input.GetAxis("S") >= 0.01)
            {
                characterPos.y += (-speed / 1.5f) * Time.deltaTime;
            }

            if (characterPos.x >= 4.0f)
            {
                characterPos.x = 4.0f;
            }

            if (characterPos.x <= -4.0f)
            {
                characterPos.x = -4.0f;
            }

            if (characterPos.y >= 4.3f)
            {
                characterPos.y = 4.3f;
            }

            if (characterPos.y <= -4.3f)
            {
                characterPos.y = -4.3f;
            }

        }

        transform.position = characterPos;
    }
}
