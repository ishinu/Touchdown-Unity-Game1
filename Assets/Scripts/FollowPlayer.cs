using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform playerTransform;
	public float offSet=8;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 cameraPos = transform.position;
		cameraPos.z = playerTransform.position.z + offSet;
		cameraPos.x = playerTransform.position.x;
		transform.position = cameraPos;


	}
}
