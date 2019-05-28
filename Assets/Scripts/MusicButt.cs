using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButt : MonoBehaviour {

	public GameObject m_on, m_off;

	void Start(){
		//PlayerPrefs.SetInt ("Music", 1);
		if (PlayerPrefs.GetInt ("Music") == 1) {
			m_off.SetActive (true);
			m_on.SetActive (false);
		} else {
			m_off.SetActive (false);
			m_on.SetActive (true);
		}
	}

	void OnMouseUpAsButton()
	{
		if (PlayerPrefs.GetInt ("Music") == 1) {
			PlayerPrefs.SetInt ("Music", 0);
			m_on.SetActive (true);
			m_off.SetActive (false);
		} else {
			PlayerPrefs.SetInt ("Music", 1);
			m_on.SetActive (false);
			m_off.SetActive (true);
		}
	}
}
