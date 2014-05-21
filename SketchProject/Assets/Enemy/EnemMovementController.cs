using UnityEngine;
using System.Collections;

public class EnemMovementController : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction_to_player = (Player.transform.position - transform.position).normalized;
		rigidbody.AddForce(direction_to_player);
	}
}
