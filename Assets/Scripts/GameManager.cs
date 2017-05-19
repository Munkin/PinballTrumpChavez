using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour 
{

	private static GameManager instance;

	public static GameManager Instance
	{
		get { return instance; }
	}

	private int puntaje;

	private int vidas;

	public event Action OnGameOver;

	public event Action OnIncreaseScore;

	public int Score
	{
		get { return puntaje; }
	}

	public int Lifes
	{
		get{ return vidas; }
	}
		

	void Awake()
	{
		vidas = 3;

		if (instance != null)
			Destroy (gameObject);
		else
			instance = this;

	}

	public void IncreaseScore()
	{
		puntaje += 50;
		if (puntaje % 1000 == 0)
			puntaje += 250;

		if (OnIncreaseScore != null)
			OnIncreaseScore ();
	}

	public void BumpersCombo()
	{

		puntaje += 1000;
		if (OnIncreaseScore != null)
			OnIncreaseScore ();
	}

	public void DecreaseLife()
	{	
		if (vidas > 0)
			vidas--;
		else {
			if(OnGameOver != null)
			OnGameOver ();
		}
	}

}
