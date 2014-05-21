using UnityEngine;
using System.Collections;

public class ForceBlast : MonoBehaviour {
	public GameObject ForceBlastEffect;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKeyUp(KeyCode.Mouse1)) 
		{


			Instantiate(ForceBlastEffect, transform.position, Quaternion.identity);
			Vector3 explosionPos = transform.position;
			Collider[] colliders = Physics.OverlapSphere (explosionPos, 5.0f);
			
			foreach (Collider hit in colliders) {
				if (!hit){
					continue;
				}
				
				if (hit.rigidbody){
					hit.rigidbody.AddExplosionForce (350.0f, explosionPos, 5.0f);
				}
			}

		}
	}
}
