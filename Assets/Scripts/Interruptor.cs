using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public static bool Activado = false;
    public Animator luz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Usar()
    {
        if (Activado == true)
        {
            luz.SetTrigger("activar");
        }
        
    }

    public void CuadroLuces()
    {
        Activado = true;
    }
}
