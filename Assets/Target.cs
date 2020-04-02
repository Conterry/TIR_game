using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
	internal int a;
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			a++;
			print(a);
		}
	}
}
