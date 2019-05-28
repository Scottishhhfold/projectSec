using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDes : MonoBehaviour {

	void Start () {
		if (GameObject.FindGameObjectsWithTag ("AudioBulk").Length == 1)
			DontDestroyOnLoad (gameObject);
		else
			Destroy (gameObject);
	}
}
