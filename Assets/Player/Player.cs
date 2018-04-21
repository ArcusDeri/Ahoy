using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	private Vector3 InputValue;
	
	// Update is called once per frame
	void Update () {
		if(!isLocalPlayer)
			return;
		InputValue.x = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime;
		InputValue.y = 0;
		InputValue.z = CrossPlatformInputManager.GetAxis("Vertical") * Time.deltaTime;
		gameObject.transform.Translate(InputValue);
	}

	public override void OnStartLocalPlayer(){
		GetComponentInChildren<Camera>().enabled = true;
		var firstCamera = GameObject.FindObjectOfType<FirstCamera>();
		if(firstCamera)
			firstCamera.enabled = false;
	}
}
