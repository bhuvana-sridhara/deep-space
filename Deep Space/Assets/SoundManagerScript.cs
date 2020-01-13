using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip explosionSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        explosionSound = Resources.Load<AudioClip>("explosionSound");
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.PlayOneShot(explosionSound);
    }
}
