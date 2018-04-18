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
		Debug.Log(Time.timeSinceLevelLoad + " host start requested.");
		StartHost();
	}

	public override void OnStartHost(){
		Debug.Log(Time.timeSinceLevelLoad + " host started.");
	}

	public override void OnStartClient(NetworkClient myClient){
		Debug.Log(Time.timeSinceLevelLoad + " client start requested.");
		InvokeRepeating("PrintDots",0,1);
	}

	public override void OnClientConnect(NetworkConnection conn){
		Debug.Log(Time.timeSinceLevelLoad + " client connected to IP: " + conn.address);
		CancelInvoke("PrintDots");
	}

	private void PrintDots(){
		Debug.Log(".");
	}
}
