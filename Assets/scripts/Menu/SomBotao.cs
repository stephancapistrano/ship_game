using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class SomBotao : MonoBehaviour {
    AudioSource audio1;

    void Start () {
        audio1 = GetComponent<AudioSource>();
    }
	
	public void TocaBotao () {
        audio1.Play();
    }
}
