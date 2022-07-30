using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Pontuacao : MonoBehaviour {

    public static float pontos;
    Text text;

    void Awake() {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        text.text = ""+Pontos.pontosint;
    }
}
