using UnityEngine;
using System.Collections;

public class Meteoro : MonoBehaviour {
	public Transform exp;
	private float vel = 2;
	private float inicio = 7; 
	private float fim = -7; 
	private float rot;
	private float rot2 = 1;
	// Use this for initialization
	void Start () {
		vel = 2;
	}
	
	void Update () {
		//VELOCIDADE DO METEORO POR NIVEL
		if (nivelJogo.nivel == 1) {
			vel = 3;
		}
		if (nivelJogo.nivel == 2) {
			vel = 4.5f;
		}
		if (nivelJogo.nivel == 3) {
			vel = 6;
		}
		if (nivelJogo.nivel == 4) {
			vel = 7.5f;
		}
		if (nivelJogo.nivel == 5) {
			vel = 10;
		}

		//MOVIMENTO E ROTAÇAO DO METEORO
		transform.Translate (0, -vel * Time.deltaTime, 0, Space.World);
		transform.Rotate (0, 0, rot2 * 15 * Time.deltaTime);


		//RELOAD DO METEORO
		if (transform.position.y <= fim) {
			transform.position = new Vector3 (Random.Range (-2.3f, 2.3f), inicio, 0);
			Pontos.pontosint += 50;
			Pontos.pontos += 50;
			rot = Random.Range (-1, 1);
			if (rot >= 0) {
				rot2 *= -1;
			}
		}
	}
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            //Destroy(gameObject);
            //Destroy(other.gameObject);
            //Pontos.pontosTotal += Pontos.pontosint;
            Instantiate(exp, transform.position, transform.rotation);
            //Application.LoadLevel("jogo_fim");
        }
    }
}
