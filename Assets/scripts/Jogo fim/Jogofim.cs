using UnityEngine;
using System.Collections;

public class Jogofim : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Pontos.pontosTotal = 0;
        Pontos.pontosTotal += Pontos.pontosint;
        PlayerPrefs.GetInt("pontosPref");
        Pontos.pontosTotal += PlayerPrefs.GetInt("pontosPref");
    }
	
	// Update is called once per frame
	void Update () {
         PlayerPrefs.SetInt("pontosPref", Pontos.pontosTotal);
        // PlayerPrefs.Save();
    }
    /*
	void OnGUI (){
		GUI.Label (new Rect(10,10,200,20),"Sua pontuaçao: "+Pontos.pontosint);
        GUI.Label(new Rect(10, 40, 200, 20), "Sua pontuaçao total: " + PlayerPrefs.GetInt("pontosPref"));

		if (GUI.Button(new Rect(10, 70, 50, 30), "Jogar")){
			Application.LoadLevel("jogo");
		}
        if (GUI.Button(new Rect(10, 140, 50, 30), "Itens")) {
            Application.LoadLevel("itens");
        }
    }
    */
    public void FimJogar() {
        Application.LoadLevel("jogo");
    }
    public void FimItens() {
        Application.LoadLevel("itens");
    }
    public void FimMenu() {
        Application.LoadLevel("menu");
    }


}
