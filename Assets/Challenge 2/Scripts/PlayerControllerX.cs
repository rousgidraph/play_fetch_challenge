using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float interval = 30f;
    public float timer = 0f;
    

    // Update is called once per frame
    void Update()
    {
        //negate the timer 
        if (timer > 0) {
            timer--;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer <=0)
        {
            timer = interval;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
