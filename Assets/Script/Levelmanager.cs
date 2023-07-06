using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levelmanager : MonoBehaviour
{
    // Start is called before the first frame update

    public Button[] listbuttonlevel;
    void Start()
    {
        CekLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CekLevel()
    {
        int levelTerakhirMain;

        if (PlayerPrefs.HasKey("LEVEL") == false)
        {
            levelTerakhirMain = 1;
        }
        else
        {
            levelTerakhirMain = PlayerPrefs.GetInt("LEVEL"); 
            SceneManager.LoadScene("Game" + levelTerakhirMain);
        }

        for (int i = 0; i < listbuttonlevel.Length; i++)
        {

            if (i < levelTerakhirMain)
                listbuttonlevel[i].interactable = true;
            else
                listbuttonlevel[i].interactable = false;
        }
    }
    public void PilihLevel(string levelBerapa)
    {
        AudioController.Instance.SoundButton();
        SceneManager.LoadScene("Game" + levelBerapa);
    }
}
