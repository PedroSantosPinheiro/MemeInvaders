using UnityEngine;
using System.Collections;

public class SpecialBullet : MonoBehaviour
{

    public float speedSpecial;

    public float lifeTime = 10;

    public int damageBomb;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, lifeTime);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speedSpecial * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Enemy2")
        {

            other.gameObject.GetComponent<SovietHealth>().HurtSoviet(damageBomb);
            

        }
    }
}
