using UnityEngine;
using System.Collections;

public class Select2 : MonoBehaviour {


    public Sprite cor1;
    public Sprite cor2;

    // Update is called once per frame
    void Update() {
        if (EscolheNave.nave == 2) {
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cor2;
        } else {
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cor1;
        }
    }
}
