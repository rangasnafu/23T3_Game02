using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Context");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game quit");
    }
}
