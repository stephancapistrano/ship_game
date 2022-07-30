using UnityEngine;
using System.Collections;

public class CanvasSlider : MonoBehaviour {

    public static int moveBlocks;
    public static int clique;

    void Start () {
        moveBlocks = 0;
        clique = 0;
	}
	
	void Update () {
        if (clique == 1) {
            if (moveBlocks == 0) {
                if (transform.position.x < 46.6f) {
                    transform.Translate(-Time.deltaTime*5,0,0);
                    transform.position = new Vector3(46.6f, -0.59f, -9.5f);
                    clique = 0;
                } else if (transform.position.x > 46.6f) {
                    transform.Translate(Time.deltaTime * 5, 0, 0);
                    transform.position = new Vector3(46.6f, -0.59f, -9.5f);
                    clique = 0;
                } else {
                    transform.Translate(0, 0, 0);
                    transform.position = new Vector3(46.6f, -0.59f, -9.5f);
                    clique = 0;
                }
                
            } else if (moveBlocks == 1) {
                transform.position = new Vector3(39.45f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 2) {
                transform.position = new Vector3(32.58f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 3) {
                transform.position = new Vector3(25.67f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 4) {
                transform.position = new Vector3(18.7f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 5) {
                transform.position = new Vector3(11.6f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 6) {
                transform.position = new Vector3(4.5f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 7) {
                transform.position = new Vector3(-2.7f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 8) {
                transform.position = new Vector3(-10.2f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 9) {
                transform.position = new Vector3(-17.71f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 10) {
                transform.position = new Vector3(-25.08f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 11) {
                transform.position = new Vector3(-32.45f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 12) {
                transform.position = new Vector3(-39.82f, -0.59f, -9.5f);
                clique = 0;
            } else if (moveBlocks == 13) {
                transform.position = new Vector3(-46.99f, -0.59f, -9.5f);
                clique = 0;
            }
            clique = 0;
        }
	}
}