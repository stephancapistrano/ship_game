using UnityEngine;
using System.Collections;

public class EscolheNave : MonoBehaviour {

    public static int nave;
    public Transform Player1;
    public Transform Player2;
    public Transform Player3;

    void Start() {
        if (nave == 0 || nave == 1) {
            Instantiate(Player1, transform.position, transform.rotation);
        }
        if (nave == 2) {
            Instantiate(Player2, transform.position, transform.rotation);
        }
        if (nave == 3) {
            Instantiate(Player3, transform.position, transform.rotation);
        }
    }
}