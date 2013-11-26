using UnityEngine;
using System.Collections;

public class MenuClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 10000.0f))
			{
				if(hit.collider.tag == "StartGame")
				{
					Application.LoadLevel("SandBox");
				}
				if(hit.collider.tag == "Direction")
				{
					Application.LoadLevel("Directions");
				}
				if(hit.collider.tag == "ExitGame")
				{
					Application.Quit();
				}
			}
		}
	}
}
