using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    Rigidbody rb;
    Vector3 jump;

    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float jumpForce = 15f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0, jumpForce, 0);
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        Vector3 dir = transform.localToWorldMatrix * new Vector3(x, 0, z);
        //Vector3 dir = transform.right * x + transform.forward * z;

        transform.position = transform.position + dir.normalized * moveSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jump * jumpForce * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
