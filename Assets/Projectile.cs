using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 10;
    public SpriteRenderer rendr;

    void Start()
    {
        rendr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.Translate(transform.up * Time.deltaTime * speed, Space.World);
        if (!rendr.isVisible)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Spawner"))
        {
            Destroy(gameObject);
        }
    }
}
