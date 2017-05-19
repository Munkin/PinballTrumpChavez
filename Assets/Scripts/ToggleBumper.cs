using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBumper : Bumper {

	private SpriteRenderer mySpriteRender;

	[SerializeField]
	private Color onColor;

	[SerializeField]
	private Color offColor;

	private BumperGroup myBumperGroup;

	void Start () {
		 
		mySpriteRender = GetComponent<SpriteRenderer> ();
		mySpriteRender.color = offColor;

	}
	

	public override void WhenItCollides ()
	{
		if (mySpriteRender.color == offColor) {
			myBumperGroup.OneMoreIsOn ();
			mySpriteRender.color = onColor;
		
		} else {
			myBumperGroup.OneMoreIsOff ();
			mySpriteRender.color = offColor;
		}
	}

	public void SetBumperGroup(BumperGroup bumpG)
	{
		myBumperGroup = bumpG;
	}

	public void RestartColor()
	{
		mySpriteRender.color = offColor;
	}
}
