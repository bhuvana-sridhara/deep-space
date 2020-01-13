using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionSound : MonoBehaviour
{
    public static AudioClip explosion;
    public static AudioSource AudioSrc;
    // Start is called before the first frame update
    void Start()
    {
        explosion = Resources.Load<AudioClip>("explosionSound");

        AudioSrc = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        if (clip.Equals("explosion"))
        {
            AudioSrc.PlayOneShot(explosion);
        }
            
    }
}
