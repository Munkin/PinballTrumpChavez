using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperGroup : MonoBehaviour {

	[SerializeField]
	private  List<ToggleBumper> bumpersList;

	private int bumpersOn;

	// Use this for initialization
	void Start () {
		foreach (ToggleBumper bumper in bumpersList)
		{
			bumper.SetBumperGroup (gameObject.GetComponent<BumperGroup> ());
		}
	}
	
	// Update is called once per frame
	public void OneMoreIsOn()
	{
		bumpersOn++;
		if (bumpersOn >= bumpersList.Count) 
		{
			GameManager.Instance.BumpersCombo ();
			RestartBumpers ();
		}
	}

	public void OneMoreIsOff()
	{
		bumpersOn--;
	}

	private void RestartBumpers()
	{
		foreach(ToggleBumper bumper in bumpersList ){
			bumper.RestartColor();
		}
	}
}
