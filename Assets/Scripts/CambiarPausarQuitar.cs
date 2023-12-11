using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarPausarQuitar : MonoBehaviour
{
    // Nombre de la escena a la que quieres cambiar
    public string proximaEscena;

    // Método para cambiar la escena
    public void CambiarEscena()
    {
        // Carga la escena con el nombre proporcionado
        SceneManager.LoadScene(proximaEscena);
    }
    public void StopScene()
    {
        Time.timeScale = 0f;
    }

    public void PlayScene()
    {
        Time.timeScale = 1f;
    }
    
    public void quitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
    }
}