using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0f, 0f, 0f);
        if (Input.GetKey(KeyCode.W))
            force = new Vector3(0f, 0f, 10f);
        if (Input.GetKey(KeyCode.S))
            force = new Vector3(0f, 0f, -10f);
        if (Input.GetKey(KeyCode.D))
            force = new Vector3(10f, 0f, 0f);
        if (Input.GetKey(KeyCode.A))
            force = new Vector3(-10f, 0f, 0f);
        if (Input.GetKey(KeyCode.Space))
            force = new Vector3(0f, 15f, 0f);
        rb.AddForce(force);
    }
}