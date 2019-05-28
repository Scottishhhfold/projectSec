using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	void Start () {
		if (GameObject.FindGameObjectsWithTag ("ClickAudio").Length == 1)
			DontDestroyOnLoad (gameObject);
		else
			Destroy (gameObject);
	}
}
