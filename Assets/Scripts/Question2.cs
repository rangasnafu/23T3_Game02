using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question2 : MonoBehaviour
{
    public void Correct()
    {
        SceneManager.LoadScene("Win");
    }

    public void Incorrect()
    {
        SceneManager.LoadScene("Lose");
    }
}
