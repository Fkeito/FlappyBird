using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        float height = Random.Range(-3.5f, 3.5f);
        this.transform.localPosition += new Vector3(0, height, 0);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += speed * Vector3.left * Time.deltaTime;
        if (this.transform.localPosition.x <= -7) ResetPos();
	}

    private void ResetPos(){
        float height = Random.Range(-3.5f, 3.5f);
        this.transform.localPosition = new Vector3(6, height, 0);
    }
}
