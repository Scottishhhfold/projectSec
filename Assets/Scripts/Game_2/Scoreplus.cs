using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreplus : MonoBehaviour {

	void OnMouseDown(){
		SpawnLight.score++;
		SpawnLight.next = true;
	}
}