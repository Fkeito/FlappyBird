using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

    public float speed;
    private MeshRenderer mr;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        mr = this.GetComponent<MeshRenderer>();
        this.GetComponent<Rigidbody>().angularVelocity = 3 * Vector3.up;

        float height = Random.Range(-6f, 6f);
        this.transform.position += new Vector3(0, height, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += speed * Vector3.left * Time.deltaTime;
        if (this.transform.position.x <= -7) ResetPos();
    }

    private void ResetPos()
    {
        float height = Random.Range(-6f, 6f);
        this.transform.position = new Vector3(6, height, 0);
        mr.enabled = true;
    }
}
