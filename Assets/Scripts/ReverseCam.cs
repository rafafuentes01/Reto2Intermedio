using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseCam : MonoBehaviour
{
    public GameObject reverseCamera; 

    void Update()
    {
        // Check if the button is being held down (you can change "Fire1" to your desired input)
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            reverseCamera.SetActive(true);
        }
        else
        {
            reverseCamera.SetActive(false);
        }
    }
}
