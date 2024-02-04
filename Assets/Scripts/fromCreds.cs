using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;

public class fromCreds : MonoBehaviour
{
    public Button backfrCreds;

    public void ClickBack()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
