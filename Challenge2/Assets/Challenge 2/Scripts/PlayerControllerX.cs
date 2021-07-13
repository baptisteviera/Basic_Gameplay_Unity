using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    private float timeWait = 0.5f;
    private float nextTime = 0.0f;
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextTime)
        {
            nextTime = Time.time + timeWait;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }

        
    }
}
