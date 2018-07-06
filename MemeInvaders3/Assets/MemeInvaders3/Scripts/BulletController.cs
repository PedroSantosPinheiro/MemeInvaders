using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public float speed;
   
    public float lifeTime = 10;

    public int damageRing;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifeTime);
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Enemy2") 
        {
            
            other.gameObject.GetComponent<SovietHealth>().HurtSoviet(damageRing);
            Destroy(gameObject);

        }
    }
}
