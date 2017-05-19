using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorEnemigos : MonoBehaviour {

	[SerializeField]
	private GameObject prefEnemigo;

	[SerializeField]
	private Transform target;

	[SerializeField]
	private Transform[] spawnPoint;

	private float elapsedTime;

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		
		elapsedTime += Time.deltaTime;
		if (elapsedTime > 2) 
		{
			elapsedTime = 0;
			CreatEnemy ();
		}
	}

	void CreatEnemy ()
	{
		int tempRandom = Random.Range (0, spawnPoint.Length);
		GameObject tempObject = (GameObject)Instantiate(prefEnemigo,spawnPoint[tempRandom].position,spawnPoint[tempRandom].rotation);
	}
}
