using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene(1);
    }

    public void Quitter()
    {
        Debug.Log("Vous avez quitter le jeu");
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }
}
