using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class SomBotao2 : MonoBehaviour {
    AudioSource audio2;
    void Start() {
        audio2 = GetComponent<AudioSource>();
    }

    public void TocaBotao2() {
        audio2.Play();
    }
}
