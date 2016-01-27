using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float velo = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody>().velocity = new Vector3(velo, 0, 0);
	}
}
