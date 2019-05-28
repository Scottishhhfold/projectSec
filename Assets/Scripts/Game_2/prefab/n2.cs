using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n2 : MonoBehaviour {

	public static bool flag = false;
	public static float f = 0f;

	void Update () {
		if (flag) {
			GetComponent <SpriteRenderer> ().color = Color.HSVToRGB (LightColo.a, LightColo.b, LightColo.c);
		} else {
			GetComponent <SpriteRenderer> ().color = Color.blue;
		}
		if (f <= 0 ) {
			if (flag)
				flag = false;
		} else {
			f -= Time.deltaTime;
		}
	}
		
	void OnMouseDown ()
	{
		if (!SpawnLight.show) {
			flag = true;
			f = 0.1f;
		}
	}

	void OnMouseUp ()
	{
		flag = false;
	}

	void OnMouseUpAsButton()
	{
		SpawnLight.Cl = 1;
	}
}