using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Animator luz;

    public void Encender()
    {
        luz.SetTrigger("activar");
    }
}
