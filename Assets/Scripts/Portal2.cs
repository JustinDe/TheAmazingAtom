using UnityEngine;
using System.Collections;

public class Portal2 : MonoBehaviour {

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
			Debug.Log("Level Next Load!!!!");
			Application.LoadLevel("gameover");
			Debug.Log("Level Next Load!!!!");
		}
	}
}
