using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    public Button startBtn;
    public Button creditsBtn;
    public Button quitBtn;

    public Scene currentScene;


    public void clickQuit()
    {
        Application.Quit();
    }

    public void clickStart()
    {
        SceneManager.LoadScene("genderChoice");
    }

    public void clickCredits()
    {
        SceneManager.LoadScene("CreditsScreen");
    }
}
