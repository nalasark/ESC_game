using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_follow : MonoBehaviour {

    public Transform target;
    public float mSpeed = 0.01f;
    Camera mycam;

	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        mycam.orthographicSize = (Screen.height / 100f) / 4f; //responsive scaling

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, mSpeed) + new Vector3(0,0,-10);
        }

	}
}