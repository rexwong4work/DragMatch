using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPositions : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//if item is 1 -> position 1
		//else item is 2 -> position 2
		if (this.gameObject.name == "First item")
			transform.position = new Vector3(100, 250, -44);
		if (this.gameObject.name == "Second item")
			transform.position = new Vector3(600, 250, -44);
		if (this.gameObject.name == "Third item")
			transform.position = new Vector3(100, 80, -44);
		if (this.gameObject.name == "Forth item")
			transform.position = new Vector3(600, 80, -44);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
