using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question1 : MonoBehaviour
{
    public GameObject correctAnswer;
    public GameObject wrongAnswer1;
    public GameObject wrongAnswer2;

    public GameObject question1UI;
    public GameObject question2UI;

    public void Correct()
    {
        question1UI.SetActive(false);
        question2UI.SetActive(true);
    }

    public void Incorrect()
    {
        SceneManager.LoadScene("Lose");
    }
}
