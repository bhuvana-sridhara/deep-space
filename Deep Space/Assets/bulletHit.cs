using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour
{
    public GameObject explosion;
    public Rigidbody2D rb;
    public AudioSource blast;


    // Start is called before the first frame update
    void Start()
    {
        blast = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Asteroid"))
        {
            Debug.Log("Made Contact");
            Destroy(collision.gameObject);
            blast.Play();
            Instantiate(explosion, transform.position, transform.rotation);
        }

    }
}
