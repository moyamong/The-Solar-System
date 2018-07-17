using UnityEngine;
using System.Collections;

public class SpaceshipController : MonoBehaviour {

	public float speed;
	public float rotatespeed;
	public float velocityx, velocityy, velocityz;
	public Vector3 velocity =new Vector3(0.0f,0.0f,0.0f);
	public float dragconstant;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		float deltamove = speed * Time.deltaTime;
		var movex = Input.GetAxis ("Horizontal");
		var movey = -Input.GetAxis ("Vertical");
		var movez = Input.GetAxis ("zaxis");
		var rotatez=Input.GetAxis ("zaxisrotate");
//		rigidbody.velocity = velocity;
		Vector3 acceleration = new Vector3 (0.0f,0.0f, movez);
		Vector3 drag = dragconstant * velocity;
//		new Vector3(velocity.x,velocity.y,0.0f)
		velocity= velocity + acceleration*Time.deltaTime-drag*Time.deltaTime;
		transform.Translate (velocity*deltamove);
//		transform.Rotation=Quaternion.Euler (new Vector3(0.0f,0.0f,-movex)*Time.deltaTime*rotatespeed);
//		rigidbody.rotation=Quaternion.Euler(0.0f,0.0f,movex*rotatespeed
		transform.Rotate (new Vector3(-movey*rotatespeed*Time.deltaTime,
			movex*rotatespeed*Time.deltaTime,
			/*-movex*0.8f*rotatespeed*Time.deltaTime*/-rotatez*0.8f*rotatespeed*Time.deltaTime));
	}
}
