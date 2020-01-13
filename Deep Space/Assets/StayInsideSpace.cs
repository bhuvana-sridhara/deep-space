using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInsideSpace : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 8f),
			Mathf.Clamp(transform.position.y, -4f, 4.5f), transform.position.z);
	}
}
