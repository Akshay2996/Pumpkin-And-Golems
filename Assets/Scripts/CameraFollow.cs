using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform pumpkinPos;
    private float yDistance = 4f;
    private float zDistance = 7f;

    void Awake ()
    {
       pumpkinPos = GameObject.Find("Pumpkin").transform;
	}

    // Update is called once per frame
    void Update ()
    {
        Vector3 temp = transform.position;
        temp.y = pumpkinPos.position.y + yDistance;
        temp.z = pumpkinPos.position.z - zDistance;
        transform.position = temp;
	}
}
