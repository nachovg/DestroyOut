using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col) {
	
		if(col.CompareTag("Bolita")){
			Rigidbody2D rb = col.GetComponent<Rigidbody2D> ();
			rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y);

			Destroy (gameObject);
		}

	}
}
