using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    
    public float bulletSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();


        rigidbody2D. AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider collider)
    {
        
    

	if(collider.gameObject.tag == "Player");
	{

	return;

	}


	if(collider.gameObject.layer == 6);
	{

	Destroy(collider.gameObject);	

	}

    Destroy(gameObject);


    }

}
