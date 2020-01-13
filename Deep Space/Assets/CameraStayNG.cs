using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStayNG : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, 85f),
            Mathf.Clamp(transform.position.y, -60f, 60f), transform.position.z);
    }
}
