using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiardeEscena : MonoBehaviour
{
    // Nombre de la escena a la que quieres cambiar
    public string pasarEscena;

    // Método para cambiar la escena
    public void CambiarEscena()
    {
        // Carga la escena con el nombre proporcionado
        SceneManager.LoadScene(pasarEscena);
    }
}