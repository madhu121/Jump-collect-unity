using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	private Vector3 left ;
	private Vector3 right ;
	private Vector3 up ;
	private Vector3 down ;
	private Vector3 zero;
	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		left = new Vector3 (-20, 0, 0);
		right = new Vector3 (20, 0, 0);
		up = new Vector3 (0, 0, 20);
		down = new Vector3 (0, 0, -20);
		zero = new Vector3 (0, 0, 0);
		count = 0;
	}
	void Update ()
	{
		if (count == 6) {
			Debug.Log ("You won!!");
		}
	}
	 public void leftmove ()
	{
		rb.AddForce (left);
	}
	public void rightmove ()
	{
		rb.AddForce (right);
	}
	public void upmove ()
	{
		rb.AddForce (up);
	}
	public void downmove ()
	{
		rb.AddForce (down);
	}
	public void zerovelocity ()
	{
		rb.AddForce (zero);
	}
	public void jump ()
	{
		rb.AddForce (new Vector3 (0, 600, 0));
			}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("p")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
		}
	}
}
