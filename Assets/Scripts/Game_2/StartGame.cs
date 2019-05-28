using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public GameObject Panels;
	public static bool start = false;

	void OnMouseUpAsButton()
	{
		Panels.SetActive (false);
		start = true;
		SpawnLight.next = true;
	}
}