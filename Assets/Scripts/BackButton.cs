using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject deskCamera;
    public GameObject bookshelfCamera;
    public GameObject binCamera;
    public GameObject rugCamera;
    public GameObject drawersCamera;
    public GameObject backButton;

    public void Back()
    {
        mainCamera.SetActive(true);
        deskCamera.SetActive(false);
        bookshelfCamera.SetActive(false);
        binCamera.SetActive(false);
        rugCamera.SetActive(false);
        drawersCamera.SetActive(false);
        backButton.SetActive(false);
    }
}
