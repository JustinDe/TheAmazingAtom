using UnityEngine;
using System.Collections;

public class door : MonoBehaviour 
{
	public static bool doorOpen = false;
	public static bool doorClose = false;
	public AudioClip doorOpenSound;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(doorOpen == true)
		{
			animation.Play("door");
			audio.PlayOneShot(doorOpenSound);
			doorOpen = false;
		}
		if(doorClose == true)
		{
			animation.Play("doorClose");
			doorClose = false;
		}
	}
}
