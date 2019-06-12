using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Fusible: MonoBehaviour
{
    
   
    public bool fusibleActivo = true;
    
    public Animator luz;
    // Start is called before the first frame update
    void Start()
    {
        Interruptor.Activado = fusibleActivo;
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Usar()
    {
        fusibleActivo = !fusibleActivo;
        Interruptor.Activado = fusibleActivo;
        luz.SetTrigger("activar");
    }

   
}
