using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainpanel;
    public GameObject creditpanel;
    public GameObject htppanel;
    public GameObject levelpanel;

    // Start is called before the first frame update
    void Start()
    {
        mainpanel.SetActive(true);
        creditpanel.SetActive(false);
        htppanel.SetActive(false);
        levelpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        mainpanel.SetActive(false);
        levelpanel.SetActive(true);
    }

    public void CreditButton()
    {
        mainpanel.SetActive(false);
        creditpanel.SetActive(true);
    }

    public void HTPButton()
    {
        mainpanel.SetActive(false);
        htppanel.SetActive(true);
    }

    public void KembaliButton()
    {
        mainpanel.SetActive(true);
        creditpanel.SetActive(false);
        levelpanel.SetActive(false);
    }

    public void KeluarButton()
    {
        Application.Quit();
    }
}
