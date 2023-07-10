using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class MoveableObject : MonoBehaviour
//{
//    public float pushForce = 1;

//    private void OnControllerColliderHit(ControllerColliderHit hit)
//    {
//        Rigidbody _rigg = hit.collider.attachedRigidbody;

//        if (_rigg != null)
//        {
//            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
//            forceDirection.y = 0;
//            forceDirection.Normalize();

//            _rigg.AddForceAtPosition(forceDirection * pushForce,transform.position, ForceMode.Impulse);

//        }
//    }
//}

public class MoveableObject : MonoBehaviour
{
    public float pushForce = 1f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Push(Vector2 pushDirection)
    {
        rb.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
    }
}