using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public static bool excite = true;
	public static bool decay = false;
	
	Vector3 startPosition;
	
	void Awake()
	{
		Screen.lockCursor = true;
		startPosition = transform.position;
	}
	// Use this for initialization
	void Start () 
	{
	
	}
	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetKeyDown(KeyCode.R))
	    {
	    	Application.LoadLevel("Menu");
	    }
		if(Input.GetButtonDown("Excite"))
		{
			decay = false;
			excite = true;
			Debug.Log ("Excite");
		}
		if(Input.GetButtonDown("Decay"))
		{
			decay = false;
			decay = true;
			Debug.Log("Decay");
		}
	}
	void OnTriggerEnter(Collider collider)
	{
		Debug.Log("Collided with: "+gameObject.tag);
		if (collider.gameObject.tag == "FallOff")
		{
				transform.position = startPosition;
				rigidbody.velocity = Vector3.zero;
				Debug.Log("I Fell");
		}
		if(collider.tag == "Platform")
		{
			transform.parent = collider.transform;
			Debug.Log ("Parented");
		}
	}
	
	void OnTriggerExit(Collider collider)
	{
		Debug.Log("On trigger exit in " + gameObject);
		if(collider.tag == "Platform")
		{
			transform.parent = null;
			Debug.Log ("Unparented");
		}
	}
}
