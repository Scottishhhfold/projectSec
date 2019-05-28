using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dest : MonoBehaviour {

	//public GameObject[] ms;
	//public static bool det = false;
	//public static float f = 0f;

	void Start()
	{
		GetComponent <SpriteRenderer> ().color = Color.HSVToRGB (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
	}

	/*void Update(){
		
		if (det) {
			Destroy (gameObject);
			//f = 0.1f;
		}

		/*if (f <= 0) {
			det = false;
			//stgm3.blb = true;
		} else {
			f -= Time.deltaTime;
		}
		/*if (det) {
			ms = GameObject.FindGameObjectsWithTag ("hidbl");
			for (int i = 0; i < ms.Length; i++) {
				Destroy (GameObject.FindGameObjectWithTag ("hidbl"));
			}
			if (ms.Length <= 1) {
				det = false;
				stgm3.blb = true;
			}
		}*/
	//}

	/*void OnMouseUp(){
		Destroy (gameObject);
	}*/
}