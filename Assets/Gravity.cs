using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {
	public float x;
//	float y=0;
	public float z;
	public float gravityconstant=667384;
	public float EarthMass=6000;
	public float SunMass=1990000;
	public float GMm;
	public float r = 15;
	public Vector3 position = new Vector3 (15.0f, 0.0f, 0.0f);
	public Vector3 velocity =new Vector3(0.0f,0.0f,0.940954f);
	// Use this for initialization
	void Start () {
		x = 15;
		z = 0;
	}

	// Update is called once per frame
	void Update () {
		Vector3 acceleration = new Vector3 (-gravityconstant*EarthMass*SunMass *z / (r*r*r) , 0, gravityconstant*EarthMass*SunMass *x/ 3375 );
		velocity = velocity + acceleration*Time.deltaTime*Time.deltaTime;
		transform.Translate (velocity * Time.deltaTime);
		x = x + velocity.x;
		z = z + velocity.z;
	}
}