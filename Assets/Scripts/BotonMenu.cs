using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonMenu : MonoBehaviour
{
    public void CargarEscena (string nombreEscena)
    {
        Application.LoadLevel (nombreEscena);
    }

    public void Salir()
    {
        Debug.Log("salido del juego");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
