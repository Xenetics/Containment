using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baddie : MonoBehaviour {

    public float speed = 2;
    public SpriteRenderer rendr;

	void Start ()
    {
        rendr = GetComponent<SpriteRenderer>();
	}
	
	void Update ()
    {
        transform.Translate(transform.up * Time.deltaTime * speed, Space.Self);
        if(!rendr.isVisible)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Projectile"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
