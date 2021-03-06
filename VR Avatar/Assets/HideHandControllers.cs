using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHandControllers : MonoBehaviour {
	private bool didHideDefaultController = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HideDefaultControllerIfNeeded();
	}
	void HideDefaultControllerIfNeeded() {
		if (!didHideDefaultController) {
			Renderer[] renderers = this.transform.parent.GetComponentsInChildren<Renderer>();
			for (int i = 0; i < renderers.Length; i++) {
				if (renderers[i].material.name == "Standard (Instance)") {
					renderers[i].enabled = false;
					didHideDefaultController = true;
				}
			}
		}
	}
}
