using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    private Rigidbody rb;
    public float jumppower;

    // Use this for initialization
    void Awake() {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
        }
    }
}
