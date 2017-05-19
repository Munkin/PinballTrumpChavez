using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	[SerializeField]
	private Transform target;
	[SerializeField]
	private float speed;

	private Rigidbody2D rb;
	private Vector3 direction;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		direction = (target.position - transform.position).normalized;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.AddRelativeForce (direction * speed);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		
		if (other.gameObject.tag == "Bola") 
		{
			gameObject.SetActive (false);
		}

		if (other.gameObject.tag == "DeadZone") 
		{
			GameManager.Instance.DecreaseLife ();
			gameObject.SetActive (false);
		}
	}
}
