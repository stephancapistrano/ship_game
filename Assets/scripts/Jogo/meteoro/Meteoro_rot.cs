using UnityEngine;
using System.Collections;

public class Meteoro_rot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0,15*Time.deltaTime);
	}
}
