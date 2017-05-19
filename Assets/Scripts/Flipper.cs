using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D rb;

	[SerializeField]
	private string elBoton;

	[SerializeField]
	private float torqueFliper;



	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		ApplyForce ();
	}

	void ApplyForce()
	{
		if (Input.GetButton(elBoton)) {
			rb.AddTorque (torqueFliper);
			//rb.rotation = Mathf.Clamp (rb.rotation, minRotation, maxRotation);
		}

	}
}
