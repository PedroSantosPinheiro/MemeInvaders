using UnityEngine;
using System.Collections;

public class TotalEnemyController : MonoBehaviour {

    GameObject[] enemies;
    GameObject currentEnemy;

    public bool isFiring;
    private bool canFire;

    public float timeBetweenShots;
    public float shotCounter;


    GameObject[] enemies2;
    GameObject currentEnemy2;

    public bool isFiring2;
    private bool canFire2;

    public float shotCounter2;

  

    // Use this for initialization
    void Start () {
        shotCounter = 0;
        canFire = true;
        shotCounter2 = 0;
        canFire2 = true;
       
    }

    // Update is called once per frame
    void Update () {


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
            int index;
            enemies = GameObject.FindGameObjectsWithTag("Enemy");
            index = Random.Range(0, enemies.Length);
            currentEnemy = enemies[index];

            foreach (Transform child in currentEnemy.transform)
                if (child.CompareTag("EnemyGun")) {
                    EnemyGunController egc = child.GetComponent<EnemyGunController>();

                    egc.Fire();

                    canFire = false;
                }
            
        }






        if (!canFire2)
        {
            if (shotCounter2 <= 0)
            {
                canFire2 = true;
            }
            else
            {
                shotCounter2 -= Time.deltaTime;
            }
        }

        if (canFire2)
        {
            shotCounter2 = timeBetweenShots;
            int index;
            enemies2 = GameObject.FindGameObjectsWithTag("Enemy2");
            index = Random.Range(0, enemies2.Length);
            currentEnemy2 = enemies2[index];

            foreach (Transform child in currentEnemy2.transform)
                if (child.CompareTag("EnemyGun"))
                {
                    EnemyGunController egc = child.GetComponent<EnemyGunController>();

                    egc.Fire();

                    canFire2 = false;
                }

        }


 





    }
}
