using UnityEngine;
using System.Collections;

public class PauseController : MonoBehaviour {


    public bool paused;
    bool isPaused;
    
    // Use this for initialization
	void Start () {

        paused = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (isPaused)
        {
            paused = !paused;
        }

        if (paused){

            Time.timeScale = 0;
        }

         else if (!paused)
        {
            Time.timeScale = 1;
        }


	}
    
    public void IsPaused(bool isPaused)
    {
        this.isPaused = isPaused;
    }

}
