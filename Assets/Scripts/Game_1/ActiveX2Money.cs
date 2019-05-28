using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveX2Money : MonoBehaviour {

	public bool Timeb = true;
	public float time;
	public float NoAct = 0;

	void OnMouseUpAsButton()
	{
		if (StartProg.X2Money >= 1 && LifeChange.lose == false && Timeb == true) {
			StartProg.X2Money--;
			StartProg.ReStore ();
			SpawnBubble.rand = 5;
			time = 15;Timeb = false;
			NoAct = 5f;
		}
	}

	void Update ()
	{
		if (NoAct <= 0) {
			Timeb = true;
		} else {
			NoAct -= Time.deltaTime;
		}

		if (time <= 0) {
			SpawnBubble.rand = 4;
		} else
			time -= Time.deltaTime;
	}
}
