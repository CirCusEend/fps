﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField]
    private float speed;

    private Vector3 movementDirection;

    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    private void MovePlayer()
    {
        rb.AddForce((movementDirection * speed) * Time.deltaTime);
    }

    private void GetInputs()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movementDirection = this.gameObject.transform.forward;
            MovePlayer();
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementDirection = -this.gameObject.transform.forward;
            MovePlayer();
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementDirection = this.gameObject.transform.right;
            MovePlayer();
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementDirection = -this.gameObject.transform.right;
            MovePlayer();
        }
    }

    private void Update()
    {
        GetInputs();
    }
}