using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public Vector3 jump;
	public float jumpForce = 2.0f;
	
	public bool isGrounded;
	Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//jump = new Vector3(0.0f, 2.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
		
		transform.Translate(0, 0, z);
		
	}
}
