using UnityEngine;
using System.Collections;

public class Pontos : MonoBehaviour {
	public static float pontos = 0;
	public static int pontosint = 0;
	public static int pontosTotal = 0;
    public static int pontosGold = 0;
	public float pontosCont = 1;
	// Use this for initialization
	void Start () {
		pontos = 0;
		pontosint = 0;
		pontosCont = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//PONTOS POR NIVEL
		if (nivelJogo.nivel == 1) pontosCont=1.2f;
		if (nivelJogo.nivel == 2) pontosCont=1.4f;
		if (nivelJogo.nivel == 3) pontosCont=1.6f;
		if (nivelJogo.nivel == 4) pontosCont=1.8f;
		if (nivelJogo.nivel == 5) pontosCont=2.0f;

		if (pontos >= pontosint + 10) pontosint += 10;

		pontos += Time.deltaTime * 7 *pontosCont;

	}

	void OnGUI() {
		//GUI.Label (new Rect(10,10,200,20),"Pontos: "+pontosint);
	}
}
