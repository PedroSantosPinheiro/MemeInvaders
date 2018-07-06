using UnityEngine;
using System.Collections;

public class SpecialGunController : MonoBehaviour {

    public bool isFiring;
    private bool canFire;

    public SpecialBullet specialBullet;

    public float timeBetweenShots;
    public float shotCounter;

    public Transform firePoint;

    // Use this for initialization
    void Start()
    {
        shotCounter = 0;
        canFire = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            if (!canFire)
            {
                if (shotCounter <= 0)
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
                SpecialBullet newSpecialBullet = Instantiate(specialBullet, firePoint.position, firePoint.rotation) as SpecialBullet;

                canFire = false;
            }

        }
        else
        {
            shotCounter -= Time.deltaTime;

        }


    }

    public void setIsFiring(bool isFiring)
    {
        this.isFiring = isFiring;
    }
}