using UnityEngine;
using System.Collections;

public class Controle : MonoBehaviour {

float vel=10f;

	void Start () {
        //PlayerPrefs.DeleteAll();
    }
	
	void Update () {
		//teclado
		if(transform.position.x <= 2.0){
			if(Input.GetKey ("right") || BotaoRight.btnRight == 1){
				transform.Translate(vel*Time.deltaTime,0,0);
			}
		}

		if (transform.position.x >= -2.0) {
			if(Input.GetKey ("left") || BotaoLeft.btnLeft == 1) {
				transform.Translate(-vel*Time.deltaTime,0,0);
			}
		}

		

        if (AcelerometroControle.controleAcel % 2 == 0)
        {
            //controle melhorado
            if (Input.acceleration.x > 0.15 && Input.acceleration.x <= 0.3)
            {
                if (transform.position.x <= 2.0)
                {
                    transform.Translate(vel * Time.deltaTime / 2, 0, 0);
                }
            }
            if (Input.acceleration.x < -0.15 && Input.acceleration.x >= -0.3)
            {
                if (transform.position.x >= -2.0)
                {
                    transform.Translate(-vel * Time.deltaTime / 2, 0, 0);
                }
            }

            //acelerometro
            if (Input.acceleration.x > 0.3)
            {
                if (transform.position.x <= 2.0)
                {
                    transform.Translate(vel * Time.deltaTime, 0, 0);
                }
            }
            if (Input.acceleration.x < -0.3)
            {
                if (transform.position.x >= -2.0)
                {
                    transform.Translate(-vel * Time.deltaTime, 0, 0);
                }
            }
        }
        else
        {
            
        }

    }
    //COLISAO COM METEORO
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
            Destroy(gameObject);
            Destroy(other.gameObject);
            //Instantiate(exp, transform.position, transform.rotation);
            Application.LoadLevel("jogo_fim");
        }
    }
 /* void OnGUI() {
		GUI.Label(new Rect(Screen.width/2,Screen.height/2,40,30),""+Input.acceleration.x);
		
	}*/
}