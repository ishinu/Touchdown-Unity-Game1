using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public new Rigidbody rigidbody;
	public float speed=10f;
	public float force = 1000f;
	public float maxX;
	public float minX;
	private Touch touch;
	//public float speed2=-1000f;
	//public float speed3=2f;
	//protected Joystick joyStick;
	//protected Joybutton joyButton;
	

	// Use this for initialization
	void Start () {
	
	//joyStick= FindObjectOfType<Joystick>();
	//joyButton=FindObjectOfType<Joybutton>();
	
	}
	
	// Update is called once per frame
	void Update () {
	        
	        //var rigidbody=GetComponent<Rigidbody>();
	        //rigidbody.velocity= new Vector3 (joyStick.Horizontal*speed2*Time.deltaTime,rigidbody.velocity.y,joyStick.Vertical*speed2*Time.deltaTime);
	        //rigidbody.AddForce (0, 0, -force * Time.deltaTime);
		Vector3 playerPos = transform.position;
		

		if (playerPos.x > maxX) {
			playerPos.x = maxX;
		}

		if (playerPos.x < minX) {
			playerPos.x = minX;
		}
		transform.position = playerPos;
		
		

		/* if (Input.touchCount > 0) {
			touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Moved) {
				transform.position = new Vector3 (transform.position.x + touch.deltaPosition.x * speed2, transform.position.y, transform.position.z);
			}
		} */

	  if(Input.GetKey(KeyCode.A))
		{
			transform.position=transform.position+ new Vector3(speed*Time.deltaTime,0,0);
			}
			if(Input.GetKey(KeyCode.D))
			{
					
				transform.position=transform.position+ new Vector3(-speed*Time.deltaTime,0,0);
			}
		if(Input.GetKey(KeyCode.W))
		{

			rigidbody.AddForce (0, 0, -600f * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S))
		{

			rigidbody.AddForce (0, 0, 800f * Time.deltaTime);
		} 
	}

	private void FixedUpdate()
	{
		rigidbody.AddForce (0, 0, -force * Time.deltaTime);
	}

}
