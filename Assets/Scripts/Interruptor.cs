using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Interruptor : MonoBehaviour
{
    public static float totalLuces = 0; // Por si queremos guardar la suma de todas las luces
    public static bool Activado = false;
    public string nombre; // Nombre del interruptor para mostrar en el panel
    public GameObject etiqueta; // Prefab de la etiqueta que vamos a crear
    private float lightTime = 0; // Tiempo que el interruptor esta encendido
    private Text textTime; // Texto que muestra el tiempo 
    private int tamañoTexto = 5;
    private bool encendida = false; // Indica si la lus esta encendida 
    public Animator luz;
    // Start is called before the first frame update
    void Start()
    {
        if (nombre == "")
        {
            // si no le ponemos nombre coge el nombre del objeto
            nombre = transform.name;
        }
       
        
    }

    
    public void Usar()
    {
        if (Interruptor.Activado == true)
        {
            encendida = !encendida;
            luz.SetTrigger("activar");
            if (encendida && lightTime == 0)
            {
                AddEtiqueta();
            }

            if (encendida)
            {
                textTime.color = new Color(130,194,224,100);
                textTime.fontSize = tamañoTexto;
            }
            else
            {
                textTime.color = new Color(56, 84, 97,100);
                textTime.fontSize = tamañoTexto;
            }
        }
        
    }

  

    void AddEtiqueta()
    {
        
        var panel = GameObject.Find("PanelUILuces"); // buscamos el panel donde mostraremos el tiempo de las luces
       
        // ---- Creacion de la etiqueta con el nombre de la luz
        var nueva_etiqueta = Instantiate(etiqueta);
        nueva_etiqueta.transform.name = "etiqueta_" + transform.name;
        nueva_etiqueta.transform.SetParent(panel.transform);
        nueva_etiqueta.GetComponent<Text>().text = nombre;
        nueva_etiqueta.GetComponent<RectTransform> ().localRotation = Quaternion.identity;
        nueva_etiqueta.GetComponent<RectTransform> ().localPosition = Vector3.zero;
        
        
        // --- Creacion de la etiqueta con el tiempo que la luz lleva encendida
        nueva_etiqueta = Instantiate(etiqueta);
        nueva_etiqueta.transform.name = "tiempo_" + transform.name;
        nueva_etiqueta.transform.SetParent(panel.transform);
        textTime = nueva_etiqueta.GetComponent<Text>();
        textTime.text = "0 s";
        nueva_etiqueta.GetComponent<RectTransform> ().localRotation = Quaternion.identity;
        nueva_etiqueta.GetComponent<RectTransform> ().localPosition = Vector3.zero;
        
        // Cada segundo actualizaremos el tiempo en la tabla
        InvokeRepeating("actualizaMarcador",1,1);
    }
    
    
    void actualizaMarcador()
    {
        
        if (encendida)
        {
            lightTime += 1;
            Interruptor.totalLuces += 1;
            textTime.text = lightTime.ToString() + " s";
            
        }
    }
}
