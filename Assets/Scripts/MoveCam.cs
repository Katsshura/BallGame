using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

    public GameObject objeto;
    private Vector3 posInicial;
	// Use this for initialization
	void Start () {
        posInicial = this.transform.position - objeto.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = objeto.transform.position + posInicial;
	}
}
