using UnityEngine;
using System.Collections;

public class EnemyBulletController : MonoBehaviour
{

    public float speed;

    public float lifeTime = 10;

    public int damageCube;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, lifeTime);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Destroy(gameObject, (float)0.01);
            Destroy(other.gameObject, (float)0.01);

        }
    }
}
