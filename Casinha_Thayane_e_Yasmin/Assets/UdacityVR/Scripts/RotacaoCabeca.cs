using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoCabeca : MonoBehaviour {

	void Start () {
		Input.gyro.enabled = true;
	}
	
	void Update () {
		Quaternion att = Input.gyro.attitude;
		att = Quaternion.Euler(90f, 0f, 0f) * new Quaternion(att.x, att.y, -att.z, -att.w);
		transform.rotation = att;
	}
}
