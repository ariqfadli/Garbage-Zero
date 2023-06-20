using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainpanel;
    public GameObject settingpanel;

    // Start is called before the first frame update
    void Start()
    {
        mainpanel.SetActive(true);
        settingpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void SettingButton()
    {
        mainpanel.SetActive(false);
        settingpanel.SetActive(true);
    }

    public void KembaliButton()
    {
        mainpanel.SetActive(true);
        settingpanel.SetActive(false);
    }

    public void KeluarButton()
    {
        Application.Quit();
    }
}
