using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicarVelocidad : MonoBehaviour {

	public Vector2 direccion;
	public float Velocidad;

	void OnTriggerEnter2D (Collider2D col) {
		if(col.CompareTag("Bolita")){
			Rigidbody2D rb = col.GetComponent<Rigidbody2D> ();
			rb.velocity = direccion.normalized * Velocidad;
		}

	}
}
