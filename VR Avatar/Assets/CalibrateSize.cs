using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalibrateSize : MonoBehaviour {
	public Transform upperArmBoneLeft, lowerArmBoneLeft;
	public Transform upperArmBoneRight, lowerArmBoneRight;

	public float scalePct = 0.05f;
	public float scaleHeight, scaleArms;

	void Start() {
		GrowHeight ();
		GrowArms ();
	}

	public void GrowHeight () {
		scaleHeight = this.transform.localScale.y + scalePct;
		this.gameObject.transform.localScale = new Vector3 (scaleHeight, scaleHeight, scaleHeight);
		print ("growHeight");
	}

	public void ShrinkHeight () {
		scaleHeight = this.transform.localScale.y - scalePct;
		this.gameObject.transform.localScale = new Vector3 (scaleHeight, scaleHeight, scaleHeight);
	}

	public void GrowArms () {
		scaleArms = lowerArmBoneLeft.localScale.y + scalePct;
		lowerArmBoneLeft.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
		upperArmBoneLeft.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
		lowerArmBoneRight.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
		upperArmBoneRight.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
		print ("growArms");
	}

	public void ShrinkArms () {
		scaleHeight = lowerArmBoneLeft.localScale.y - scalePct;
		lowerArmBoneLeft.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
		upperArmBoneLeft.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
		lowerArmBoneRight.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
		upperArmBoneRight.localScale = new Vector3 (scaleArms, scaleArms, scaleArms);
	}
}
