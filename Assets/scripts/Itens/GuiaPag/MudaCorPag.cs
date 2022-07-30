using UnityEngine;
using System.Collections;

public class MudaCorPag : MonoBehaviour {

    public Sprite cor1;
    public Sprite cor2;

	void Update () {
        if (CanvasSlider.moveBlocks == 0) {
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cor2;
        } else {
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cor1;
        }
    }
}
