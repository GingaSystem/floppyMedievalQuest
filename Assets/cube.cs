using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("cubeだよ！");
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += transform.forward;
        }else if(Input.GetKey(KeyCode.DownArrow)){
            transform.position -= transform.forward;
        }
	}
}
