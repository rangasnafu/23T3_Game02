using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Confirmation : MonoBehaviour
{
    public GameObject yesButton;
    public GameObject noButton;
    public GameObject confirmationUI;

    public void Yes()
    {
        SceneManager.LoadScene("Questions");
    }

    public void No()
    {
        confirmationUI.SetActive(false);
    }

}
