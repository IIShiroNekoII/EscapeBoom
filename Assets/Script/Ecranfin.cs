using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ecranfin : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Reco()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitter()
    {
        Debug.Log("Vous avez quitter le jeu");
        Application.Quit();
    }
}
