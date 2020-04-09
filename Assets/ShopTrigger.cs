using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTrigger : MonoBehaviour
{

	public GameObject PressE;
	public GameObject Panel;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Ethan")
		{
			PressE.SetActive(true);
		}
	}

	private void OnTriggerStay(Collider other)
	{ 
		if (other.tag == "Ethan")
		{

			if (Input.GetKey(KeyCode.E))
			{				
				print("Не покупай печеньки");	
				PressE.SetActive(false);
				print(Cursor.visible);
				Cursor.visible = true;
				Panel.SetActive(true);
			}
			if (Input.GetKey(KeyCode.F))
			{
				CloseAll();
			}
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Ethan")
			CloseAll();
	}

	private void CloseAll()
	{
		PressE.SetActive(false);
		Cursor.visible = false;
		Panel.SetActive(false);
	}
}
