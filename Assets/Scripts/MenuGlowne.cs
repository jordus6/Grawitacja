using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuGlowne : MonoBehaviour
{
    

    
    public void Zagraj()
    {
        SceneManager.LoadScene("poprawki");

    }
    public void Zamknij()
    {
        Debug.Log("Aplikacja zostala zamknieta!");
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene("poprawki");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }



}
