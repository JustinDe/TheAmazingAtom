using UnityEngine;
using System.Collections;

public class Button2 : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "Moveable")
		{
			exitDoor.doorOpen = true;
			Debug.Log ("On Button");
		}
	}
	void OnTriggerExit(Collider collider)
	{
		if(collider.tag == "Moveable")
		{
			exitDoor.doorClose = true;
			Debug.Log ("Off Button");	
		}
	}
}
