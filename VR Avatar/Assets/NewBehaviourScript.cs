using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : SteamVR_TrackedController {

	public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int) controllerIndex); } }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
