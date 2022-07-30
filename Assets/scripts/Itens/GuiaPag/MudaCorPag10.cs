using UnityEngine;
using System.Collections;

public class MudaCorPag10 : MonoBehaviour {

    public Sprite cor1;
    public Sprite cor2;
    //private SpriteRenderer spriteRenderer3;

    // Use this for initialization
    void Start() {
        //spriteRenderer3 = GetComponent<SpriteRenderer>();
        //if (spriteRenderer3.sprite == null) { spriteRenderer3.sprite = cor1; }
    }

    // Update is called once per frame
    void Update() {
        if (CanvasSlider.moveBlocks == 10) {
            //spriteRenderer3.sprite = cor2;
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cor2;
        } else {
            //spriteRenderer3.sprite = cor1;
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cor1;
        }
    }
}

