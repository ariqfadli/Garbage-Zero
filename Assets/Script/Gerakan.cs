using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerakan : MonoBehaviour
{

    Rigidbody2D rb;
    public float kecepatan = 2f;
    private Vector3 gerakan;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GerakKeAtas()
    {
        gerakan = Vector3.up;
    }

    public void GerakKeBawah()
    {
        gerakan = Vector3.down;
    }

    public void GerakKeKiri()
    {
        gerakan = Vector3.left;
    }

    public void GerakKeKanan()
    {
        gerakan = Vector3.right;
    }

    public void Berhenti()
    {
        gerakan = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gerakan * kecepatan * Time.deltaTime);
    }
}
