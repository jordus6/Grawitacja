using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuGlowne : MonoBehaviour
{
    public void Zagraj()
    {
        SceneManager.LoadScene(1);

    }
    public void Zamknij()
    {
        Debug.Log("Aplikacja zostala zamknieta!");
        Application.Quit();
    }
}
