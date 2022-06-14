using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	public Text finalScoreText;

	int myScore = 0;  
	
	// Update is called once per frame
	void Update () {
		scoreText.text = myScore.ToString();
		finalScoreText.text = "SCORE: "+ myScore.ToString ();

	}
	public void AddScore(int score)
	{
		myScore = myScore + score;
	}
}
