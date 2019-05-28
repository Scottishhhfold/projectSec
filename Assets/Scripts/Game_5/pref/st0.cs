using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class st0 : MonoBehaviour {

	int n = 0;

	void OnMouseUpAsButton()
	{
		if (Game5.cl) {
			Game5.up0 = true;
			Game5.cl = false;
			Game5.Z = n;
		}
	}

	void Update () {
		if (Game5.up0) {
			gameObject.GetComponent <Animation> ().Play ("up0");
			Game5.up0 = false;
		}
		if (Game5.flip1) {
			gameObject.GetComponent <Animation> ().Play ("flip1_0");
			//Game5.flip1 = false;
		}
		if (Game5.flip3) {
			gameObject.GetComponent <Animation> ().Play ("flip3_0");
			//Game5.flip3 = false;
		}
		if(Game5.down0)
		{
			gameObject.GetComponent <Animation> ().Play ("down0");
			Game5.down0 = false;
		}
	}
}
/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class st0 : MonoBehaviour {

	int n = 0;

	void OnMouseUpAsButton()
	{
		switch (n) {
		case 0:
			Game5.up0 = true;
			break;
		case 1:
			Game5.up1 = true;
			break;
		case 2:
			Game5.up2 = true;
			break;
		}
	}

	void Update () {
		if (Game5.up0 && n == 0) {
			gameObject.GetComponent <Animation> ().Play ("up0");
			Game5.up0 = false;
		}
		if (Game5.up1 && n == 1) {
			gameObject.GetComponent <Animation> ().Play ("up1");
			Game5.up1 = false;
		}
		if (Game5.up2 && n == 2) {
			gameObject.GetComponent <Animation> ().Play ("up2");
			Game5.up2 = false;
		}
		if (Game5.flip1 && n == 0) {
			gameObject.GetComponent <Animation> ().Play ("flip1_0");
			//Game5.flip1 = false;
			n = 1;
		}
		if (Game5.flip1 && n == 1) {
			gameObject.GetComponent <Animation> ().Play ("flip1_1");
			//Game5.flip1 = false;
			n = 0;
		}
		if (Game5.flip2 && n == 1) {
			gameObject.GetComponent <Animation> ().Play ("flip2_0");
			//Game5.flip1 = false;
			n = 2;
		}
		if (Game5.flip2 && n == 2) {
			gameObject.GetComponent <Animation> ().Play ("flip2_1");
			//Game5.flip1 = false;
			n = 1;
		}
		if (Game5.flip3 && n == 0) {
			gameObject.GetComponent <Animation> ().Play ("flip3_0");
			//Game5.flip1 = false;
			n = 2;
		}
		if (Game5.flip3 && n == 2) {
			gameObject.GetComponent <Animation> ().Play ("flip3_1");
			//Game5.flip1 = false;
			n = 0;
		}
	}
}*/