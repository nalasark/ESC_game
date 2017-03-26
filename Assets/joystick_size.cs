using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick_size : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        float size = (Screen.width / (12f/1.5f)) / 106.6667f;
        transform.localScale = new Vector3(size, size);
    }
}
