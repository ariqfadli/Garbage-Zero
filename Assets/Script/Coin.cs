//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SocialPlatforms.Impl;
//using UnityEngine.UI;

//public class Coin : MonoBehaviour
//{
//    public int nilaikoin;
//    Rigidbody2D rb;

//    public Text txkoin;

//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();

//        txkoin.text = nilaikoin + " ";
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.tag == "Coin")
//        {
//            nilaikoin += 100;

//            txkoin.text = nilaikoin + " ";

//            Destroy(collision.gameObject);
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int nilaikoin;
    Rigidbody2D rb;
    public Text txkoin;
    public GameObject panelHasilSkor;

    private int totalKoin;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        txkoin.text = nilaikoin.ToString();
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            nilaikoin += 100;
            txkoin.text = nilaikoin.ToString();
            Destroy(collision.gameObject);

            CheckAllCoinsCollected();
        }
    }

    private void CheckAllCoinsCollected()
    {
        totalKoin--;
        if (totalKoin <= 0)
        {
            ShowScorePanel();
        }
    }

    private void ShowScorePanel()
    {
        // Menampilkan panel hasil skor
        panelHasilSkor.SetActive(true);

        // Menambahkan skor ke panel hasil skor
        Text skorText = panelHasilSkor.GetComponentInChildren<Text>();
        skorText.text = "Skor Anda adalah : " + nilaikoin.ToString();
    }
}
