using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject deskCamera;
    public GameObject bookshelfCamera;
    public GameObject binCamera;
    public GameObject rugCamera;
    public GameObject drawersCamera;
    public GameObject backButton;
    public GameObject doorButton;
    public GameObject confirmationUI;
    public GameObject buttonsUI;
    public GameObject autopsyReportCamera;
    //public GameObject autopsyReportUI;

    public void Desk()
    {
        mainCamera.SetActive(false);
        deskCamera.SetActive(true);
        backButton.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void Bookshelf()
    {
        mainCamera.SetActive(false);
        bookshelfCamera.SetActive(true);
        backButton.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void Bin()
    {
        mainCamera.SetActive(false);
        binCamera.SetActive(true);
        backButton.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void Rug()
    {
        mainCamera.SetActive(false);
        rugCamera.SetActive(true);
        backButton.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void Drawers()
    {
        mainCamera.SetActive(false);
        drawersCamera.SetActive(true);
        backButton.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void Door()
    {
        confirmationUI.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void AutopsyReport()
    {
        mainCamera.SetActive(false);
        buttonsUI.SetActive(false);
        backButton.SetActive(true);
        autopsyReportCamera.SetActive(true);
        //autopsyReportUI.SetActive(true);
    }

    //public void Back()
    //{
    //    mainCamera.SetActive(true);
    //    deskCamera.SetActive(false);
    //    bookshelfCamera.SetActive(false);
    //    binCamera.SetActive(false);
    //    rugCamera.SetActive(false);
    //    drawersCamera.SetActive(false);
    //    backButton.SetActive(false);
    //}
}
