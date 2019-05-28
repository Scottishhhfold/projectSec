using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class st1 : MonoBehaviour {

	int n = 1;

	void OnMouseUpAsButton()
	{
		if (Game5.cl) {
			Game5.up1 = true;
			Game5.cl = false;
			Game5.Z = n;
		}
	}

	void Update () {
		if (Game5.up1) {
			gameObject.GetComponent <Animation> ().Play ("up1");
			Game5.up1 = false;
		}
		if (Game5.flip1) {
			gameObject.GetComponent <Animation> ().Play ("flip1_1");
			Game5.flip1 = false;
		}
		if (Game5.flip2) {
			gameObject.GetComponent <Animation> ().Play ("flip2_0");
			//Game5.flip2 = false;
		}
		if(Game5.down1)
		{
			gameObject.GetComponent <Animation> ().Play ("down1");
			Game5.down1 = false;
		}
	}
}