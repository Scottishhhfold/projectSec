using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColo : MonoBehaviour {
	public static float a = 0.18f, b = 0.7f, c = 0.9f;
	public static bool dest = false;

	void Update ()
	{
		if(dest)
		{
			Destroy(gameObject);
		}
	}

	void OnMouseUpAsButton()
	{
		if (!SpawnLight.show) {
			SpawnLight.m1 = true;
			SpawnLight.incz++;
		}
	}
}