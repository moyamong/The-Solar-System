using UnityEngine;
using System.Collections;

public class GravityRigidbodyMars : MonoBehaviour {
	public Transform TheSun;
	public float sunmass=2000000;
	public float G=0.00000000006674f;
	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity=new Vector3 (0,0,0.00243f);
	}

	// Update is called once per frame
	void Update () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		Vector3 Mars=GameObject.Find("Mars").transform.position;
		Vector3 Sun=GameObject.Find("TheSun").transform.position;
		Vector3 distvector = TheSun.position - transform.position;
		float distance=Vector3.Distance(TheSun.position, transform.position);
		float distanceqube = distance * distance * distance;
		Vector3 Gravity = distvector * sunmass * G *0.1067f/ distanceqube;
		rb.AddForce (Gravity);
	}
}
//using UnityEngine;
//using System.Collections;

//public class GravityRigidbody : MonoBehaviour { 
/*	public Transform target;
/*	public float speed;
	void Start(){
	}
	void Update() {
		Vector3 targetDir = target.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
		Debug.DrawRay(transform.position, newDir, Color.red);
		transform.rotation = Quaternion.LookRotation(newDir);
	}
}*/