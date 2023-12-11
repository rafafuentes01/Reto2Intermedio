using UnityEngine;

public class SonidoMotor : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip motor;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = motor;
                audioSource.Play();
                audioSource.volume = 0.15f;
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
