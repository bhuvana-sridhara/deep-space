using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShuttle : MonoBehaviour
{
    public GameObject accomplish;
    public KeyCode launch;
    public GameObject camera;
    public GameObject camera2;


    private void Start()
    {
        camera.SetActive(true);
        camera2.SetActive(false);
        accomplish.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(launch))
        {
            camera2.SetActive(true);
            Destroy(camera);
            accomplish.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
            Camera.main.transform.parent = null;
            Debug.Log("Made Contact");
			Destroy(collision.gameObject);
            accomplish.SetActive(true);
          
            //transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);

            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            //transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);

        }


    }
}
