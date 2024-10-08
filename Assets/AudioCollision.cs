using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollision : MonoBehaviour
{
    AudioSource _audioSource;
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 playerPos = collision.transform.position;
            Vector3 thisPos = transform.position;
            if (playerPos.y < thisPos.y)
                _audioSource.Play();
            print("Chocar");
        }
    }
}
