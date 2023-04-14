using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 3;
    public float rotateSpeed = 5;
    public float jumpForce = 6;

    public bool isGrounded = true;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        checkIfGrounded();
        reactForKeyDown();
    }

    void checkIfGrounded()
    {
        this.isGrounded = this.gameObject.transform.position.y <= 2.5f;
    }

    void reactForKeyDown()
    {

        if (!isGrounded) return;

        if ( Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        }

        if ( Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * -1);
        }

        if ( Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if ( Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, Input.GetAxis("Rotate") * rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, Input.GetAxis("Rotate") * rotateSpeed * Time.deltaTime * -1, 0);
        }

        if ( Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

    }
}
