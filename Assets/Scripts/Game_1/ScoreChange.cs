using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour {

	public static int score = 0;
	public static int n = 4;
	float k = 0;

	void Update () {
		gameObject.GetComponent<Text> ().text = score.ToString();

		if (score == 0) {
			MoveBubble.fallSpeed = 4;
			SpawnBubble.SpeedSpawn = 1.5f;
		}
		if (score > n) {
			n = score;
			n += 2;
		}
		if (score == n)
		{
			MoveBubble.fallSpeed += 0.1f;
			SpawnBubble.SpeedSpawn -= 0.1f;
			k = SpawnBubble.SpeedSpawn;
			if (k < 0.4f)
				SpawnBubble.SpeedSpawn = 0.4f;
			n += 2;
		}
	}

	public static void ScoreUP(){
		score++;
	}
}
