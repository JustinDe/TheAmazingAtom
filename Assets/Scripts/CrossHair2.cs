using UnityEngine;
using System.Collections;

public class CrossHair2 : MonoBehaviour 
{
	public static float range = 15.0f;
	public static bool redLaser = false;
	public static bool blueLaser = false;
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
							Crate2.weightUp = true;
							Crate2.weightDown = false;
						}
						if(Player.decay == true)
						{
							Crate2.weightDown = true;
							Crate2.weightUp = false;
						}
					}
				}
			}
		}
	}
}
