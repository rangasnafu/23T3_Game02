using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question2 : MonoBehaviour
{
    public GameObject correctAnswer;
    public GameObject wrongAnswer1;
    public GameObject wrongAnswer2;

    public void Correct()
    {
        SceneManager.LoadScene("Win");
    }

    public void Incorrect()
    {
        SceneManager.LoadScene("Lose");
    }
}
