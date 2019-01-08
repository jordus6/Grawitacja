using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPauzy : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject MenuPauzyUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key:KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Wroc();
            }
            else
            {
                Pauza();
            }
        }
    }
     public void Wroc()
    {
        MenuPauzyUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pauza()
    {
        MenuPauzyUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    public void Zamkniecie()
    {
        Debug.Log ("Zamykanie gry...");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Wroc();
    }
    public void Level1()
    {
        SceneManager.LoadScene("poprawki");
        Wroc();
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
        Wroc();
    }
}
