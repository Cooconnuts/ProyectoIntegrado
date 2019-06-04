using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptorGeneral : MonoBehaviour
{
    public Animator luz1;
    public Animator luz2;
    public Animator luz3;


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
        luz1.SetTrigger("activar");
        luz2.SetTrigger("activar");
        luz3.SetTrigger("activar");
    }
}
