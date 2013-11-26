using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
	
	public AudioClip laserUp;
	public AudioClip laserDown;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			if(Player.excite == true)
			{
				renderer.enabled = true;
				GetComponent<Renderer>().material.color = Color.red;
				audio.PlayOneShot(laserDown);
			}
			if(Player.decay == true)
			{
				renderer.enabled = true;
				GetComponent<Renderer>().material.color = Color.blue;
				audio.PlayOneShot(laserUp);
			}
		}
		if(Input.GetMouseButtonUp(0))
		{
			renderer.enabled = false;	
		}	
		
	}
}
