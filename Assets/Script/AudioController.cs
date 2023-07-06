using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AudioController : MonoBehaviour
{
    public static AudioController Instance { get; set; }

    public AudioSource audioSourceDefault;
    public AudioClip audioClipButton;
    public Sprite[] spriteMute;
    public AudioClip[] clipMusic;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void ChangeMusic()
    //{
    //    for (int i = 0; i < clipMusic.Length; i++)
    //    {
    //        if (i == SceneManager.GetActiveScene().buildIndex);
    //        {
    //            audioSourceDefault.Stop();

    //            audioSourceDefault.clip = clipMusic[i];

    //            audioSourceDefault.Play();

    //            break;
    //        }
    //    }
    //}

    public void MuteSound(Image imageMute)
    {
        if (audioSourceDefault.mute == false)
        {
            audioSourceDefault.mute = true;
            imageMute.sprite = spriteMute[0];
        }
        else
        {
            audioSourceDefault.mute = false;
            imageMute.sprite = spriteMute[1];
        }    
    }

    public void SoundButton()
    {
        audioSourceDefault.PlayOneShot(audioClipButton);
    }
}
