using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    public GameObject[] carros; 
    private int actual = 0;
    private Color colorSeleccion;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            VerAnterior();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            VerSiguiente();
        }
    }
    public void VerSiguiente()
    {
        carros[actual].SetActive(false); 
        actual = (actual + 1) % carros.Length; 
        carros[actual].SetActive(true); 
    }

    public void VerAnterior()
    {
        carros[actual].SetActive(false); 
        actual = (actual - 1 + carros.Length) % carros.Length; 
        carros[actual].SetActive(true); 
    }

    public void CambiarColorCarro()
    {
        Transform carroSel = carros[actual].transform.Find("Muscle 2");

        if (carroSel != null)
        {
            Renderer renderer = carroSel.GetComponent<Renderer>();

            if (renderer != null)
            {
                Material materialHijo = renderer.material;
                colorSeleccion = materialHijo.color;
            }
        }
        PlayerPrefs.SetFloat("R", colorSeleccion.r);
        PlayerPrefs.SetFloat("G", colorSeleccion.g);
        PlayerPrefs.SetFloat("B", colorSeleccion.b);
        PlayerPrefs.SetFloat("A", colorSeleccion.a);
    }
}
