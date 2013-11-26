using UnityEngine;
using System.Collections;

public class Crate : MonoBehaviour 
{
	public static bool weightUp = false;
	public static bool weightDown = false;
	public static float gunPower = 0.01f;
	public static float crateMass = 0.001f;
	// Use this for initialization
	void Start () 
	{
		rigidbody.mass = crateMass;
	}
	
	// Update is called once per frame
	void Update () 
	{
		rigidbody.mass = crateMass;
		if(weightUp == true)
		{
			Debug.Log ("Weight Up");
			crateMass += 0.01f;
			weightUp = false;
			
		}
		if(weightDown == true)
		{
			Debug.Log ("Weight Down");
			crateMass -= 0.01f;
			weightDown = false;
		}
	}
}
