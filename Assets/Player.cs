using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject FocusPoint;
    public GameObject Pivot;
    public float Speed = 5;
    public GameObject Projectile;
    public GameObject ShootPoint;
    public float ShotCooldown = 1;
    public float ShotTimer = 0;
    public bool CanShoot = true;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Pivot.transform.Rotate(transform.forward * Input.GetAxis("Horizontal") * Time.deltaTime * Speed);

        if (!CanShoot)
        {
            ShotTimer += Time.deltaTime;
            if(ShotTimer >= ShotCooldown)
            {
                CanShoot = true;
                ShotTimer = 0;
            }
        }

        if(Input.GetButtonDown("Shoot"))
        {
            if (CanShoot)
            {
                Instantiate(Projectile, ShootPoint.transform.position, Quaternion.Euler(Vector3.up + Pivot.transform.rotation.eulerAngles));
                CanShoot = false;
            }
        }
	}
}
