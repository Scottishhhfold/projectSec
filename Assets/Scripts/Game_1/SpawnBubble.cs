using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBubble : MonoBehaviour {
	public static float SpeedSpawn = 1.3f;
	public GameObject[] bubble;
	public static int rand = 4;
	public Text MaxScore;
	public Text Money;
	private int n = 0;

	void Start () 
	{			
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn()
	{
		while (!LifeChange.lose) 
		{
			Instantiate (bubble[Random.Range(0,rand)],new Vector2(Random.Range(-2.5f,2.5f),5.9f),Quaternion.identity);
			yield return new WaitForSeconds (SpeedSpawn);
		}
	}
		
	void Update () 
	{
		if (PlayerPrefs.GetInt ("Music") == 1) {
			GetComponent <AudioSource> ().Play ();
		}
		if (LifeChange.lose) {
			MaxScore.text = StartProg.MaxScore.ToString();
			Money.text = StartProg.Money.ToString ();
		}

	}
}