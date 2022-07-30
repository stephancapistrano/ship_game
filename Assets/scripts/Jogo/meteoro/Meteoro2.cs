using UnityEngine;
using System.Collections;

public class Meteoro2 : MonoBehaviour {
	public Transform exp2;
	private float vel2 = 2;
	private float inicio2 = 7; 
	private float fim2 = -7; 
	private float rot2;
	private float rot22 = 1;
	
	// Use this for initialization
	void Start () {
		vel2 = 2;
		transform.position = new Vector3(Random.Range(-2.3f,2.3f), 14, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (nivelJogo.nivel == 1) {
			vel2=3;
		}
		if (nivelJogo.nivel == 2) {
			vel2=4.5f;
		}
		if (nivelJogo.nivel == 3) {
			vel2=6;
		}
		if (nivelJogo.nivel == 4) {
			vel2=7.5f;
		}
		if (nivelJogo.nivel == 5) {
			vel2=10;
		}

		transform.Translate (0,-vel2*Time.deltaTime,0, Space.World);
		transform.Rotate (0,0,rot22*15*Time.deltaTime);
		
		if (transform.position.y <= fim2) {
			transform.position = new Vector3(Random.Range(-2.3f,2.3f), inicio2, 0);
			Pontos.pontosint += 50;
			Pontos.pontos += 50;
			rot2 = Random.Range(-1,1);
			if(rot2 >= 0){
				rot22 *= -1;
			}
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")){
			//Destroy (gameObject);
			//Destroy(other.gameObject);
			//Pontos.pontosTotal += Pontos.pontosint;
			Instantiate(exp2,transform.position,transform.rotation);
			//Application.LoadLevel("jogo_fim");
		}
	}
}
