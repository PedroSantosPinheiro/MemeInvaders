using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public EnemyGunController theEnemyGun;
    public float min = -2f;
    public float max = 3f;
    public float speed = 20;
    // Use this for initialization
    void Start()
    {

        min = transform.position.x - 15;
        max = transform.position.x + 15;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, max - min) + min, transform.position.y, transform.position.z);
    }
}