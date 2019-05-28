using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col4 : MonoBehaviour {

	int n = 4;
	float f = 1.8f;

	void Update () {
		if (Game4.clz [1] == Game4.clz [2] && Game4.clz [1] == n) {
			if (f < 0) {
				Game4.score++;
				Destroy (gameObject);
			} else {
				f -= Time.deltaTime;
			}
		}
		if (Game4.show) {
			GetComponent <SpriteRenderer> ().color = Game4.colors [n];
			Game4.f+= 0.1f;
		}
	}

	void OnMouseUpAsButton()
	{
		if (Game4.cl) {
			Game4.Z = Game4.Z + 1;
			GetComponent <SpriteRenderer> ().color = Game4.colors [n];
			Game4.clz [Game4.Z] = n;
			Game4.f = 2f;
		}
	}
}