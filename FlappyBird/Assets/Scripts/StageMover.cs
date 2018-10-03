using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += -2f * Vector3.left * Time.deltaTime;
	}
}
