using UnityEngine;

public class AsignarColor : MonoBehaviour
{
     void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (PlayerPrefs.HasKey("ColorR"))
        {
            
            float r = PlayerPrefs.GetFloat("R");
            float g = PlayerPrefs.GetFloat("G");
            float b = PlayerPrefs.GetFloat("B");
            float a = PlayerPrefs.GetFloat("A");

            Color colorAsignado = new Color(r, g, b, a);
            renderer.material.color = colorAsignado;
        }
    }
}
