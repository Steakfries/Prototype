using UnityEngine;
using System.Collections;

public class PlayerStatusController : MonoBehaviour {
	public int Lives = 5;
	public GameObject EnemyExplosionEffect;

	public void OnGUI(){
		GUI.Label(new Rect(20, 20, 100, 20), System.String.Format("LIVES: {0}", Lives));
		}

	public void OnCollisionEnter(Collision other){
		Lives --;


		Vector3 enemy_position = other.transform.position;
		Destroy (other.gameObject);
		
		Instantiate(EnemyExplosionEffect, enemy_position, Quaternion.identity);

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


        //ParticleSystem explosion = (ParticleSystem)Instantiate(EnemyExplosionEffect, enemy_position, Quaternion.identity);
		//explosion.Emit();
				
	}
}
