using UnityEngine;
using System.Collections;

// class must be the same as the fileanme
public class playerscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal"); 
		float vertical = Input.GetAxis ("Vertical");
		transform.Translate (horizontal, vertical, 0);
	}
}
