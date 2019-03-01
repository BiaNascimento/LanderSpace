using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {
	public float impulso;
	public float lateral;
	public float inclinacao;
	public Rigidbody2D batata;

	// Use this for initialization
	void Start () {
		Rigidbody batata = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update () {
		

		if (Input.GetKey(KeyCode.Space)) {
			batata.AddForce(Vector3.up * impulso);
		}
		if (Input.GetKey(KeyCode.D))
		{
			batata.AddForceAtPosition(this.transform.right * inclinacao, new Vector2(-43, 15));
			batata.AddForce(Vector3.right * lateral);

		}
		if (Input.GetKey(KeyCode.A))
		{
			batata.AddForceAtPosition(-this.transform.right*inclinacao, new Vector2(-43, 15));
			batata.AddForce(Vector3.left * lateral);
		}
	}


}