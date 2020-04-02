using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRigid : MonoBehaviour {

	void Start()
	{
		Rigid();
	}


	void Rigid()
	{
		Rigidbody Rb = gameObject.GetComponent<Rigidbody>();

		Rb.AddForce(transform.forward * 300);
	}
}
