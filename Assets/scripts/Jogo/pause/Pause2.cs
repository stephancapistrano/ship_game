using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pause2 : MonoBehaviour {

    private float pause = 0;
	//private string texto = "vazio";

    public Sprite pause1;
    public Sprite pause2;
    private SpriteRenderer spriteRenderer2;


    void Start () {
		pause = 0;
        spriteRenderer2 = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer2.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer2.sprite = pause1; // set the sprite to sprite1
    }
	
	void Update () {
		for(int i = 0 ; i < Input.touches.Length ; i++){ // quantos toques voce tem ??
			Touch touch = Input.touches[i]; //o toque
			Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch(i).position);
			RaycastHit hit = new RaycastHit ();
			
			if(Physics.Raycast(ray,out hit,1000)){
				if(hit.collider.gameObject == this.gameObject){
					if(touch.phase == TouchPhase.Began){
						//texto = "funfou";
						pause += 1;
					}
					else if(touch.phase == TouchPhase.Ended){
						//texto = "Ended";
					}
					else if(touch.phase == TouchPhase.Moved){
						//texto = "Moved";
					}
					else if(touch.phase == TouchPhase.Canceled){
						//texto = "Canceled";
					}
					else if(touch.phase == TouchPhase.Stationary){
						//texto = "Stationary";
					}
				}
			}
		}
		//PAUSE
		if (Input.GetKeyDown ("p")) {
			pause += 1;
		}
		if (pause % 2 == 0) {
			Time.timeScale = 1.0f;
            spriteRenderer2.sprite = pause1;
        } else {
			Time.timeScale = 0.0f;
            spriteRenderer2.sprite = pause2;
        }
	}
	/*void OnGUI (){
		GUI.Label (new Rect (40,50,600,20),"oi: "+pause);
	}*/
}