using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(Vector3.left*speed*Time.deltaTime);
	}
	public int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.name == "BGLooper") {     
			float widthOfBGObject = ((BoxCollider2D)GetComponent<Collider2D>()).size.x - 0.01f;   
			Vector3 pos = this.transform.position;    
			pos.x += widthOfBGObject* numBGPanels;    
			this.transform.position = pos;   
		}
	}
}
