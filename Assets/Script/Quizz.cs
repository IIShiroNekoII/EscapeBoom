using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quizz : MonoBehaviour
{
    public void rouge()
    {
        SceneManager.LoadScene(2);
    }

    public void jaune()
    {
        SceneManager.LoadScene(2);
    }

    public void bleu()
    {
        SceneManager.LoadScene(3);
    }

    public void vert()
    {
        SceneManager.LoadScene(2);
    }
}
