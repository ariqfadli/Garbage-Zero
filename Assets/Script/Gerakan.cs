//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Gerakan : MonoBehaviour
//{

//    Rigidbody2D rb;
//    public float kecepatan = 2f;
//    private Vector3 gerakan;
//    private Animator animator;
//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//    }

//    public void GerakKeAtas()
//    {
//        gerakan = Vector3.up;
//        UpdateAnimatorParameters();
//    }

//    public void GerakKeBawah()
//    {
//        gerakan = Vector3.down;
//        UpdateAnimatorParameters();
//    }

//    public void GerakKeKiri()
//    {
//        gerakan = Vector3.left;
//        UpdateAnimatorParameters();
//    }

//    public void GerakKeKanan()
//    {
//        gerakan = Vector3.right;
//        UpdateAnimatorParameters();
//    }

//    public void Berhenti()
//    {
//        gerakan = Vector3.zero;
//        UpdateAnimatorParameters();
//    }

//    private void UpdateAnimatorParameters()
//    {
//        animator.SetFloat("Horizontal", gerakan.x);
//        animator.SetFloat("Vertical", gerakan.y);
//        animator.SetFloat("Speed", gerakan.sqrMagnitude);
//    }
//    // Update is called once per frame
//    void Update()
//    {
//        transform.Translate(gerakan * kecepatan * Time.deltaTime);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerakan : MonoBehaviour
{
    public float kecepatan = 2f;
    private Vector3 gerakan;
    private Animator animator;
    private Rigidbody2D rb;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void GerakKeAtas()
    {
        gerakan = Vector3.up;
        UpdateAnimatorParameters();
    }

    public void GerakKeBawah()
    {
        gerakan = Vector3.down;
        UpdateAnimatorParameters();
    }

    public void GerakKeKiri()
    {
        gerakan = Vector3.left;
        UpdateAnimatorParameters();
    }

    public void GerakKeKanan()
    {
        gerakan = Vector3.right;
        UpdateAnimatorParameters();
    }

    public void Berhenti()
    {
        gerakan = Vector3.zero;
        UpdateAnimatorParameters();
    }

    private void UpdateAnimatorParameters()
    {
        animator.SetFloat("Horizontal", gerakan.x);
        animator.SetFloat("Vertical", gerakan.y);
        animator.SetFloat("Speed", gerakan.sqrMagnitude);
    }

    private void Update()
    {
        rb.velocity = gerakan * kecepatan;
    }
}



