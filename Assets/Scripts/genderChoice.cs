using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;

public class genderChoice : MonoBehaviour
{
    public Button femBtn, mascBtn;

    public void ClickFem()
    {
        SceneManager.LoadScene("femCustomization");
    }

    public void ClickMasc()
    {
        SceneManager.LoadScene("mascCustomization");
    }
}
