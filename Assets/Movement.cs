using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private bool isGrounded;
    int ground;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ground = 8;
    }

    // Update is called once per frame
    void Update()
    {
      //  isGrounded = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1.5f, ground);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed * Time.deltaTime, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Force);
        }
    }
}
