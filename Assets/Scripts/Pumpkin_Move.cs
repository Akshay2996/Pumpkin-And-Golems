using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin_Move : MonoBehaviour {

    public float moveForce = 10f;
    private Rigidbody myBody;
    //Awake Runs Before Start function
    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
		if(transform.position.y < -5)
        {
            Time.timeScale = 0f;
        }
	}
    //FixUpdate is called once 1/3 or 1/4 per frame
    void FixedUpdate()
    {
        MovePumpkin();
    }

    void MovePumpkin()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        myBody.AddForce(new Vector3(h * moveForce, 0f ,v * moveForce));
    }
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Golem" || target.tag == "Gates")
        {
            Time.timeScale = 0f;
        }
    }
}
