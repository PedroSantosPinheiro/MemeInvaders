using UnityEngine;
using System.Collections;

public class EnemyGunController : MonoBehaviour
{

    public bool isFiring;
    private bool canFire;

    public EnemyBulletController enemyBullet;
    public float timeBetweenShots;
    public float shotCounter;

    public Transform firePoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Fire() {
        shotCounter = timeBetweenShots;
        EnemyBulletController newEnemyBullet = Instantiate(enemyBullet, firePoint.position, firePoint.rotation) as EnemyBulletController;
        GameObject tec = GameObject.Find("ImageTarget/TotalEnemyControllerObject");
        newEnemyBullet.transform.parent = tec.transform;
    }
}
