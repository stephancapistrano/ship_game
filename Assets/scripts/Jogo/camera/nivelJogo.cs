using UnityEngine;
using System.Collections;

public class nivelJogo : MonoBehaviour {
	public static float nivel = 0;
	// Use this for initialization
	void Start () {
		nivel = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Pontos.pontosint>=150) {
			nivel=1;
		}
		if (Pontos.pontosint>=400) {
			nivel=2;
		}
		if (Pontos.pontosint>=1000) {
			nivel=3;
		}
		if (Pontos.pontosint>=2000) {
			nivel=4;
		}
		if (Pontos.pontosint>=3500) {
			nivel=5;
		}
	}
}
