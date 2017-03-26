using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_follow : MonoBehaviour {

    public Transform target;
    public float mSpeed = 0.01f;
    public float res = 2f;
    Camera mycam;

	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, mSpeed) + new Vector3(0,0,-10);
        }

	}
}