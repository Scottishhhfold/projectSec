using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivFrozi : MonoBehaviour {
	public bool Timeb = true;
	public float time;

	void OnMouseUpAsButton()
	{
		if (StartProg.Frozi >= 1 && LifeChange.lose == false && Timeb == true) {
			StartProg.Frozi--;
			StartProg.ReStore ();
			MoveBubble.fallSpeed /= 2;
			SpawnBubble.SpeedSpawn += 0.1f;
			time = 1f;Timeb = false;
		}
	}

	void Update ()
	{
		if (time <= 0) {
			Timeb = true;
			ButtonPanel.Activ = !Timeb;
			ButtonPanel.NameButton = "But";
		} else
			time -= Time.deltaTime;	
	}
}
