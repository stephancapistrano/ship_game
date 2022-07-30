using UnityEngine;
using System.Collections;

public class RodaEspaco : MonoBehaviour {
	public float velespac = 10;
	// Use this for initialization
	void Start () {
		velespac =10;
	}
	
	// Update is called once per frame
	void Update () {
		if (nivelJogo.nivel == 1) {
			velespac =15;
		}
		if (nivelJogo.nivel == 2) {
			velespac =20;
		}
		if (nivelJogo.nivel == 3) {
			velespac =25;
		}
		if (nivelJogo.nivel == 4) {
			velespac =30;
		}
		if (nivelJogo.nivel == 5) {
			velespac =35;
		}
		transform.Rotate (-velespac*Time.deltaTime,0,0);
	}
}
