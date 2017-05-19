using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {

	[SerializeField]
	private float applyForce;

	// Use this for initialization
	void Start () {

	

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Vector3 direction = (other.transform.position - transform.position).normalized;

		AddFroceToOther (other, direction);
		WhenItCollides ();
	}

	void AddFroceToOther (Collision2D other, Vector3 direction)
	{
		GameManager.Instance.IncreaseScore ();

		other.gameObject.GetComponent<Rigidbody2D> ().AddForce (direction * applyForce);
	}

	public virtual void WhenItCollides ()
	{



	}


	// Update is called once per frame
	void Update () {
		
	}
}
