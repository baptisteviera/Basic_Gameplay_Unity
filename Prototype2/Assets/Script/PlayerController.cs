using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed=40.0f;

    public float xrange = 10.0f;
    
    public GameObject prefabProjectiles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }
        // déplacement du personnage
        horizontalInput = Input.GetAxis(("Horizontal"));
        
        transform.Translate((Vector3.right * (horizontalInput * Time.deltaTime * speed)));


        if (Input.GetKeyDown(KeyCode.Space))
        {
            // le joueur lance un projectile
            // instantiate permet de faire des copies de gameObject
            // attention ne pas oublier la prefab rotation
            Instantiate(prefabProjectiles, transform.position, prefabProjectiles.transform.rotation);

        }
    }
}
