using UnityEngine;

public class SonidosPistas : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip semaforoSonido;
    public AudioClip fondoSonido;

    void Start()
    {
        audioSource.clip = semaforoSonido;
        audioSource.loop = false;
        audioSource.volume = 0.5f;
        audioSource.Play();
        audioSource.SetScheduledEndTime(AudioSettings.dspTime + semaforoSonido.length);
        Invoke("FondoSonido", semaforoSonido.length);
    }

    void FondoSonido()
    {
        audioSource.clip = fondoSonido;
        audioSource.loop = true;
        audioSource.volume = 0.2f;
        audioSource.Play();
    }
}
