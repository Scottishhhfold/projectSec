using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBomb : MonoBehaviour {
	
	public bool Timeb = true;
	public float time;
	public float NoAct = 0;

	void OnMouseUpAsButton()
	{
		if (StartProg.Bomb >= 1 && LifeChange.lose == false && Timeb == true) {
			StartProg.Bomb--;
			StartProg.ReStore ();
			MoveBubble.bomb = true;
			time = 0.5f;Timeb = false;
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
			MoveBubble.bomb = false;
		} else
			time -= Time.deltaTime;
	}
}
