using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        this.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update () {
        this.transform.Translate(Vector3.up * Time.deltaTime * 2, Space.World);
    }
}
