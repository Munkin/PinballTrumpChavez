using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	[SerializeField]
	private int Vidas;

	[SerializeField]
	private Text gameOverText;

	[SerializeField]
	private GameObject myFlip1, myFlip2;



	public void PerderVidas(){

		if (Vidas > 0)
			Vidas--;
		else
			Perdiste ();
	}

	void Perdiste ()
	{
		gameOverText.text = "Perdiste";
		myFlip1.SetActive (false);
		myFlip2.SetActive (false);
	}
}
