using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgameon()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitbutton()
    {
        Application.Quit();
    }
}
