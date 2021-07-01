using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;
    public GameManager gameManager;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce((transform.forward + transform.right)* speed,
            ForceMode.VelocityChange);
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            rb.velocity = Vector3.zero;
            gameManager.GameOver();
        }
    }
}
