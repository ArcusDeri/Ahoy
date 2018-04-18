using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MyStartHost(){
		Debug.Log("Starting host at " + Time.timeSinceLevelLoad);
		StartHost();
	}

	public override void OnStartHost(){
		Debug.Log("Host started at " + Time.timeSinceLevelLoad);
	}
}
