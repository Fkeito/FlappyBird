using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float jumpVelocity;

    private GameOverManager goManager;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        goManager = GameObject.Find("GameManager").GetComponent<GameOverManager>();
	}
	
	// Update is called once per frame
	void Update () {
        //rb.AddForce(15 * Vector3.down, ForceMode.Acceleration);

        if(Input.GetMouseButtonDown(0)){
            rb.velocity = jumpVelocity *  Vector3.up;
        }
	}

    void LateUpdate()
    {
        //90 ~ -90
        float rotY = Mathf.Clamp(rb.velocity.y / jumpVelocity * 90f, -90f, 90f);
        Quaternion rot = Quaternion.Euler(0 ,0 ,rotY);
        this.transform.localRotation = rot;
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Obstacle")){
            goManager.GameOver();
            Destroy(this.gameObject);
        }
    }
}
