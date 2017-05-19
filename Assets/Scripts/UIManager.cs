using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	[SerializeField]
	private Text scoreText;

	[SerializeField]
	private Text gameOverText;

	[SerializeField]
	private GameObject flippers;

	[SerializeField]
	private GameObject generador;

	// Use this for initialization
	void Start () {
		GameManager.Instance.OnGameOver += SetGameOver;
		GameManager.Instance.OnIncreaseScore += SetScoreText;
	}
	
	// Update is called once per frame

	private void SetGameOver ()
	{
		flippers.SetActive (false);
		generador.SetActive (false);
		gameOverText.text = "Fail";

	}

	private void SetScoreText ()
	{
		scoreText.text = string.Format ("Score "+ GameManager.Instance.Score);
	}

}
