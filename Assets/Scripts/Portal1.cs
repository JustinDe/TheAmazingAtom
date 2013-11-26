using UnityEngine;
using System.Collections;

public class Portal1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "Player")
		{
			Application.LoadLevel("Main");
			Debug.Log("Level Next Load!!!!");
		}
	}
}
