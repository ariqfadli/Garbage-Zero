using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class htpscript : MonoBehaviour
{
    public GameObject panelUtama; // Panel utama yang akan menampung panel lainnya
    public GameObject panelChild; // Panel yang akan ditampilkan di dalam panel utama
    public GameObject childPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanggilPanelChild()
    {
        panelChild.SetActive(true);
        childPanel.SetActive(false);
    }

    public void PanggilChildPanel()
    {
        childPanel.SetActive(true);
        panelChild.SetActive(false);
    }

    public void TutupChildPanel()
    {
        childPanel.SetActive(false);
        panelChild.SetActive(false);
    }

}
