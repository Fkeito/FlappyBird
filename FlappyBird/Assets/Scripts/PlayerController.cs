using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float jumpVelocity;

    public GameObject player;
    public ParticleSystem trail;
    private ParticleSystem.MainModule _trail;
    public GameObject explosion;

    private GameOverManager goManager;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        goManager = GameObject.Find("GameManager").GetComponent<GameOverManager>();
        _trail = trail.main;
	}
	
	// Update is called once per frame
	void Update () {
        //rb.AddForce(15 * Vector3.down, ForceMode.Acceleration);

        if(Input.GetMouseButtonDown(0)){
            rb.velocity = jumpVelocity *  Vector3.up;
        }
	}

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Obstacle")){
            goManager.GameOver();

            //見ため
            Destroy(player);

            //動きとめる
            Destroy(rb);

            //エフェクト
            _trail.loop = false;
            var e = trail.emission; e.enabled = false;
            explosion.SetActive(true);

            Destroy(this);
        }
    }
}
