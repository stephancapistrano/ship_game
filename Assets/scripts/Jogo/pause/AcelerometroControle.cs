using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AcelerometroControle : MonoBehaviour {

    public static float controleAcel = 0;

    public Sprite acel1;
    public Sprite acel2;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {
        controleAcel = 0;
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = acel1; // set the sprite to sprite1
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touches.Length; i++)
        { // quantos toques voce tem ??
            Touch touch = Input.touches[i]; //o toque
            Ray ray2 = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray2, out hit, 1000))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    if (touch.phase == TouchPhase.Began)
                    {
                        //texto = "funfou";
                        controleAcel += 1;
                    }
                    else if (touch.phase == TouchPhase.Ended)
                    {
                        //texto = "Ended";
                    }
                    else if (touch.phase == TouchPhase.Moved)
                    {
                        //texto = "Moved";
                    }
                    else if (touch.phase == TouchPhase.Canceled)
                    {
                        //texto = "Canceled";
                    }
                    else if (touch.phase == TouchPhase.Stationary)
                    {
                        //texto = "Stationary";
                    }
                }
            }
        }

        //escolhendo sprite
        if (controleAcel % 2 == 0) {
            spriteRenderer.sprite = acel1;
        } else {
            spriteRenderer.sprite = acel2;
        }
    }
}
