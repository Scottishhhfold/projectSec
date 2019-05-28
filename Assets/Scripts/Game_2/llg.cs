using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llg : MonoBehaviour {

	void OnMouseUp ()
	{
		SpawnLight.inc++;
	}

	/*
	void new_level1(){
		//score++;
		if (score <= 6) {
			Instantiate (bubble [0], new Vector2 (0f, 1.8f), Quaternion.identity);
			Instantiate (bubble [1], new Vector2 (0f, -1.8f), Quaternion.identity);
		} else if (score <= 14) {
			Instantiate (bubble [0], new Vector2 (0f, 1.8f), Quaternion.identity);
			Instantiate (bubble [1], new Vector2 (-1.5f, -0.8f), Quaternion.identity);
			Instantiate (bubble [2], new Vector2 (1.5f, -0.8f), Quaternion.identity);
		} else if (score <= 24) {
			Instantiate (bubble [0], new Vector2 (0f, 1.8f), Quaternion.identity);
			Instantiate (bubble [1], new Vector2 (0f, -1.8f), Quaternion.identity);
			Instantiate (bubble [2], new Vector2 (1.8f, 0f), Quaternion.identity);
			Instantiate (bubble [3], new Vector2 (-1.8f, 0f), Quaternion.identity);
		} else if (score <= 36) {
			Instantiate (bubble [0], new Vector2 (0f, 1.8f), Quaternion.identity);
			Instantiate (bubble [1], new Vector2 (1f, -1.4f), Quaternion.identity);
			Instantiate (bubble [2], new Vector2 (-1.6f, 0.5f), Quaternion.identity);
			Instantiate (bubble [3], new Vector2 (-1f, -1.4f), Quaternion.identity);
			Instantiate (bubble [4], new Vector2 (1.6f, 0.5f), Quaternion.identity);
		} else {
			Instantiate (bubble [0], new Vector2 (0f, 1.8f), Quaternion.identity);
			Instantiate (bubble [1], new Vector2 (0f, -1.8f), Quaternion.identity);
			Instantiate (bubble [2], new Vector2 (-1.5f, 0.8f), Quaternion.identity);
			Instantiate (bubble [3], new Vector2 (-1.5f, -0.8f), Quaternion.identity);
			Instantiate (bubble [4], new Vector2 (1.5f, 0.8f), Quaternion.identity);
			Instantiate (bubble [5], new Vector2 (1.5f, -0.8f), Quaternion.identity);
		}
		LightColo.dest = true;
		f = 0.001f;
	}*/
}
