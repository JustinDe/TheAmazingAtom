using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	bool menu2 = false;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Menu") && menu2 == false)
		{
			menu2 = true;
			animation.Play("menuFlip");
			Screen.lockCursor = false;
		}
	}
}
