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

    public Image imageButtonMute;

    // Start is called before the first frame update
    void Start()
    {
        mainpanel.SetActive(true);
        creditpanel.SetActive(false);
        htppanel.SetActive(false);
        levelpanel.SetActive(false);

        if(AudioController.Instance.audioSourceDefault.mute == true)
        {
            imageButtonMute.sprite = AudioController.Instance.spriteMute[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMuteSound()
    {
        AudioController.Instance.MuteSound(imageButtonMute);
    }

    public void StartButton()
    {
        AudioController.Instance.SoundButton();

        mainpanel.SetActive(false);
        levelpanel.SetActive(true);
    }

    public void CreditButton()
    {
        AudioController.Instance.SoundButton();

        mainpanel.SetActive(false);
        creditpanel.SetActive(true);
    }

    public void HTPButton()
    {
        AudioController.Instance.SoundButton();

        mainpanel.SetActive(false);
        htppanel.SetActive(true);
    }

    public void KembaliButton()
    {
        AudioController.Instance.SoundButton();

        mainpanel.SetActive(true);
        creditpanel.SetActive(false);
        levelpanel.SetActive(false);
    }

    public void KeluarButton()
    {
        AudioController.Instance.SoundButton();

        Application.Quit();
    }
}
