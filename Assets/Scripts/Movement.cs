using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [Header("Definir Velocidade")]
    public float velocidade;
    [Header("Particula")]
    public GameObject particulaItem;

    private Rigidbody rigidB;

	// Use this for initialization
	void Start () {
        rigidB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        rigidB.AddForce(move * velocidade);
		
	}

    private void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.CompareTag("ItemReward"))
        {
            Instantiate(particulaItem, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            ScoreManager.instance.increasePoints();
        }
    }
}
