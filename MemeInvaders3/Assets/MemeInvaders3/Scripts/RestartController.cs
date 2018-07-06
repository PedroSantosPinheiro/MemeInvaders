using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartController : MonoBehaviour
{

    bool isRestart;

    void Start()
    {
        
    }

  public void RestartScene()
    {
        SceneManager.LoadScene("MemeInvaders3", LoadSceneMode.Single);
    }
}