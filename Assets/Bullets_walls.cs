using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets_walls : MonoBehaviour {

	public GameObject bullet;
	public GameObject wall;
	public Transform Cam;
	public Transform SpawnPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			SpawnBullets();
		}
		if (Input.GetKeyDown(KeyCode.Mouse1))
		{
			SpawnWalls();
		}
	}

	public GameObject SpawnBullets()
	{
		return Instantiate(bullet, SpawnPos.transform.position, SpawnPos.transform.rotation);
	}
	public GameObject SpawnWalls()
	{
		return Instantiate(wall, SpawnPos.transform.position, SpawnPos.transform.rotation);
	}
}
