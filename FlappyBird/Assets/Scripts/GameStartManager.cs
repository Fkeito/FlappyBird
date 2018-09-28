using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartManager : MonoBehaviour {

    public Rigidbody player;
    public ObstacleController[] obstacles;
    public GameObject startCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            startCanvas.SetActive(false);
            player.useGravity = true;
            foreach(ObstacleController oc in obstacles){
                oc.enabled = true;
            }

            Destroy(this);
        }
	}
}
