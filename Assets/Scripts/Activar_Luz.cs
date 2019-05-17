using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Luz : MonoBehaviour
{
    Animator animacion;

    public GameObject[] luces;


    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
