using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HS : MonoBehaviour
{
    public string MM;
    public string NS;

    public void NextScene()
    {
        SceneManager.LoadScene(NS);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(MM);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
