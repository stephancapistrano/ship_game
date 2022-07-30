using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BotaoLeft : MonoBehaviour {
    public static float btnLeft = 0;
    // Use this for initialization
    void Start () {
        btnLeft = 0;
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touches.Length; i++) { // quantos toques voce tem ??
            Touch touch = Input.touches[i]; //o toque
            Ray ray2 = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray2, out hit, 1000)) {
                if (hit.collider.gameObject == this.gameObject) {
                    if (touch.phase == TouchPhase.Began) {
                        //texto = "funfou";
                        btnLeft = 1;
                    } else if (touch.phase == TouchPhase.Ended) {
                        //texto = "Ended";
                        btnLeft = 0;
                    } else if (touch.phase == TouchPhase.Moved) {
                        //texto = "Moved";
                    } else if (touch.phase == TouchPhase.Canceled) {
                        //texto = "Canceled";
                    } else if (touch.phase == TouchPhase.Stationary) {
                        //texto = "Stationary";
                    }
                }
            }
        }
    }
}
