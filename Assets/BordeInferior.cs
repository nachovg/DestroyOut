using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordeInferior : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {
		if(col.CompareTag("Bolita")){
			col.SendMessage ("Iniciar");
		}
		
	}
}
