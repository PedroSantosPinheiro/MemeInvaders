using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GunController theGun;
    public SpecialGunController theSpecialGun;
    bool isMovingRight;
    bool isMovingLeft;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (isMovingRight)
            transform.Translate(15f * Time.deltaTime, 0f, 0f);

        if (isMovingLeft)
            transform.Translate(-15f * Time.deltaTime, 0f, 0f);
       /*
        if (Input.GetMouseButtonDown(0))
            theGun.isFiring = true;

        if (Input.GetMouseButtonUp(0))
            theGun.isFiring = false;
            
        if (Input.GetMouseButtonDown(1))
            theSpecialGun.isFiring = true;

        if (Input.GetMouseButtonUp(1))
            theSpecialGun.isFiring = false;
        */  
    }
    public void IsMovingRight(bool isMovingRight)
    {
        transform.Translate(15f * Time.deltaTime, 0f, 0f);
        this.isMovingRight = isMovingRight;
    }

    public void IsMovingLeft(bool isMovingLeft)
    {
        transform.Translate(-15f * Time.deltaTime, 0f, 0f);
        this.isMovingLeft = isMovingLeft;
    }
   

}