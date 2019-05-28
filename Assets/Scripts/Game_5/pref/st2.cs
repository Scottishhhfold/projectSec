using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class st2 : MonoBehaviour {

	int n = 2;

	void OnMouseUpAsButton()
	{
		if (Game5.cl) {
			Game5.up2 = true;
			Game5.cl = false;
			Game5.Z = n;
		}
	}


		
	void Update () {
		//gameObject.GetComponent <Animation> ().Play ("flip3_1");
		if (Game5.up2) {
			gameObject.GetComponent <Animation> ().Play ("up2");
			Game5.up2 = false;
		}
		if (Game5.flip2) {
			gameObject.GetComponent <Animation> ().Play ("flip2_1");
			Game5.flip2 = false;
		}
		if (Game5.flip3) {
			gameObject.GetComponent <Animation> ().Play ("flip3_1");
			Game5.flip3 = false;
		}
		if(Game5.down2)
		{
			gameObject.GetComponent <Animation> ().Play ("down2");
			Game5.down2 = false;
		}
	}
}