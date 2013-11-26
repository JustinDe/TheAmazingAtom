using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour 
{
	public static float range = 15.0f;
	public static bool redLaser = false;
	public static bool blueLaser = false;
	public float pickUpRange = 5.0f;
	Transform pickObj = null;
	Vector3 newPos;
	float dist;
	public float projForce = 2.0f;
	public float grabDistance = 2.0f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Player.excite == true)
		{
			GetComponent<Renderer>().material.color = Color.red;
		}
		if(Player.decay == true)
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}
		if(Input.GetMouseButton(0))
		{
			
			RaycastHit hit;
			Vector3 DirectionRay = transform.TransformDirection(Vector3.forward);
			Debug.DrawRay(transform.position, DirectionRay * range, Color.blue);
			if(Physics.Raycast(transform.position, DirectionRay, out hit, range))
			{
				if(hit.rigidbody)
				{
					if(hit.collider.gameObject.tag == "Moveable")
					{
						Debug.Log("BOOM");
						if(Player.excite == true)
						{
							Crate.weightUp = true;
							Crate.weightDown = false;
						}
						if(Player.decay == true)
						{
							Crate.weightDown = true;
							Crate.weightUp = false;
						}
					}
				}
			}
		}
	}
}