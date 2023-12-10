using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaAuto : MonoBehaviour
{
    public string siguienteEscena;
    void Start()
    {
        Invoke("CargarSiguienteEscena", 3f);
    }

    void CargarSiguienteEscena()
    {

            SceneManager.LoadScene(siguienteEscena);
        
    }
}
