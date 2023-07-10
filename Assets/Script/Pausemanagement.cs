using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemanagement : MonoBehaviour
{
    public GameObject panelpause;

    public void PauseControl()
    {
        if(Time.timeScale == 1)
        {
            panelpause.SetActive(true);
            Time.timeScale = 0;
        }
        else 
        {
            Time.timeScale = 1;
            panelpause.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MenuUtama()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
