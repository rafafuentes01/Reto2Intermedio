using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float velocidadRotacion = 60.0f; 
    public bool girarEnY = true;

    void Update()
    {
        Vector3 ejes = new Vector3(0, girarEnY ? 1 : 0, 0);
        transform.Rotate(ejes * velocidadRotacion * Time.deltaTime);
    }
}
