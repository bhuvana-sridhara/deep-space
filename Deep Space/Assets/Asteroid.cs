using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float maxThrust;
    public float maxTorque;
    public Rigidbody2D rb;
    public float screenBottom;
    public float screenLeft;
    public float screenRight;
    public float screenTop;
    public GameObject explosion;
    public AudioSource blast;
    public GameObject died;




    //public void playBlast()
    //{
    //    blast.Play();
    //}

    // Start is called before the first frame update
    void Start()
    {
        Vector2 thrust = new Vector2(Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust));
        float torque = Random.Range(-maxTorque, maxTorque);
        died.SetActive(false);
        rb.AddForce(thrust);
        rb.AddTorque(torque);
        blast = GetComponent<AudioSource>();

    }

    // Update is called once per framerb
    void Update()
    {
        Vector2 newPos = transform.position;
        if(transform.position.y > screenTop)
        {
            newPos.y = screenBottom;
        }
        if (transform.position.y < screenBottom)
        {
            newPos.y = screenTop;
        }
        if (transform.position.x > screenRight)
        {
            newPos.x = screenLeft;
        }
        if (transform.position.x < screenLeft)
        {
            newPos.x = screenRight;
        }
        transform.position = newPos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //blast.Play();

        if (collision.gameObject.tag == "Player")
        {
            //audio.Play();
            Debug.Log("Made Contact");
            Destroy(collision.gameObject);
            //blast.PlayOneShot(explosionSound);
            //explosionSound.PlaySound("explosion");
           blast.Play();
            died.SetActive(true);

            Instantiate(explosion, transform.position, transform.rotation);

        }
        if (collision.gameObject.tag == "Bullet")
        {
            //audio.Play();

            Debug.Log("Bullet Made Contact");
            //Destroy(collision.gameObject);
            Destroy(collision.gameObject);

            blast.Play();
            //blast.PlayOneShot(explosionSound);
            // playBlast();
            //explosionSound.PlaySound("explosion");
            Instantiate(explosion, transform.position, transform.rotation);
            //explosionSound.PlaySound("explosion");
        }


    }
}
