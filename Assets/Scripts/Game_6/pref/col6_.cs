using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col6_ : MonoBehaviour {

	int n = 6;
	void Start()
	{
		gameObject.transform.Rotate (0,0,Game6.rot[(int)Random.Range (0, 3)]);
	}

	void OnMouseUpAsButton()
	{
		if (Game6.cl && !Game6.clic) {
			Game6.N = n;
			Game6.clic = true;
		}
	}
}