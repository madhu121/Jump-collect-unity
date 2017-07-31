using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDownMovement : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y <6.01) {
			rb.AddForce (new Vector3 (0f, 25f, 0f));
		}
		else if(transform.position.y >8)
		{
			rb.AddForce (new Vector3(0f, -25f, 0f));
				}
	}
}
