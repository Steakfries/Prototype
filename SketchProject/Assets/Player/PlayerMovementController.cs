using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

	public float MovementSpeed = 1.0f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Escape))
			Screen.lockCursor = false;
		else
			Screen.lockCursor = true;

		float delta_x = Input.GetAxis ("Mouse X");
		float delta_y = Input.GetAxis ("Mouse Y");

		transform.position = new Vector3(transform.position.x + (delta_x * MovementSpeed), transform.position.y + (delta_y * MovementSpeed), 0);
	}
}
