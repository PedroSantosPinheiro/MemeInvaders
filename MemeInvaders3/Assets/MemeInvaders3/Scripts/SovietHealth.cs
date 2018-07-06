using UnityEngine;
using System.Collections;

public class SovietHealth : MonoBehaviour {

    public int health;
    private int currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = health;
	
	}
	
	// Update is called once per frame
	void Update () {

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	
	}

    public void HurtSoviet(int damage)
    {
        currentHealth -= damage; 
    }
}
