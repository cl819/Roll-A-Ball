﻿using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (new Vector3 (15, 0, 45) * Time.deltaTime);
	}
}
