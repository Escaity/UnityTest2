using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;
    private int lbCount = 0;

    // Start is called before the first frame update
    private void Start()
    {
        this.player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = player.transform.position + offset;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -90f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 90f, 0f);
        }
    }

    private void FixedUpdate()
    {
    }
}