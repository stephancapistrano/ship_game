using UnityEngine;
using System.Collections;

public class BtnMenu : MonoBehaviour {

    public void BtnJogar() {
        Application.LoadLevel("jogo");
    }
    public void BtnItens() {
        Application.LoadLevel("itens");
    }
    public void BtnSair() {
        Application.Quit();
    }
}
