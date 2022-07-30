using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using static System.Net.Mime.MediaTypeNames;

public class PontosItens : MonoBehaviour {

    public static float pontosGold;
    Text text;

    void Awake() {
        text = GetComponent<Text>();
        Pontos.pontosGold = Pontos.pontosTotal;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "PONTOS: " + Pontos.pontosGold;
	}
}
