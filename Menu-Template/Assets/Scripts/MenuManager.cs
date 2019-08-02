using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame()
    {
        Debug.Log("play");
        SceneManager.LoadScene("LoadingScene");
    }

    public void showCredits()
    {
        Debug.Log("creditos");
        SceneManager.LoadScene("Creditos");
    }

    public void exitGame()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
