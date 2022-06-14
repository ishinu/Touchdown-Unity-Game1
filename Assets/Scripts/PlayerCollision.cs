using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public PlayerScript playerScript;
	public Score score;
	public GameController gameController;
	public AudioSource audioSource;
	public AudioSource audioSource2;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Collectable") {
			audioSource.Play ();
			score.AddScore (1);
			Destroy (other.gameObject);

		}
	
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Obstacles") {
			audioSource2.Play ();
			gameController.GameOver ();
			playerScript.enabled = false;
		}

	}

}
