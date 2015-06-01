using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	
	private void OnTriggerEnter(Collider c){
		c.SendMessage("OnGoal");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
