using UnityEngine;
using System.Collections;

public class NaveSelect : MonoBehaviour {
    void Start() {
        if(EscolheNave.nave == 0) {
            EscolheNave.nave = 1;
        }
    }

	public void EscolheNave1 () {
        EscolheNave.nave = 1;
    }

    public void EscolheNave2() {
        EscolheNave.nave = 2;
    }

    public void EscolheNave3() {
        EscolheNave.nave = 3;
    }
}
