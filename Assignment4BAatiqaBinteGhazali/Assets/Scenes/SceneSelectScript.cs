using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void GotoPenguin()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void GotoHummingbird()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("MainMenu"); ;
    }
}
