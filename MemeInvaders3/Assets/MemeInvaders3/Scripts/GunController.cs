using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

    public bool isFiring;
    private bool canFire;

    public BulletController bullet;
    public float timeBetweenShots;
    public float shotCounter;

    public Transform firePoint;

	// Use this for initialization
	void Start () {
        shotCounter = 0;
        canFire = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFiring)
        {
            if (!canFire)
            {
                if(shotCounter <= 0)
                {
                    canFire = true;
                }
                else
                {
                    shotCounter -= Time.deltaTime;
                }
            }

            if (canFire)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;

                canFire = false;
            }

        } else {
            shotCounter -= Time.deltaTime;

        }

	
	}

    public void setIsFiring(bool isFiring)
    {
        this.isFiring = isFiring;
    }
}
