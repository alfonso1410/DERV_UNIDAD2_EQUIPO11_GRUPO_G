using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S7_ControlTiempoConRutina : MonoBehaviour
{
    // Start is called before the first frame update

    int contador_segundos;
    [SerializeField] TextMeshProUGUI TextoTiempo;
    void Start()
    {
        contador_segundos = 0;
        StartCoroutine("corrutinaTiempo");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator corrutinaTiempo(){
        while(true){
            TextoTiempo.text = contador_segundos++.ToString();
            yield return new WaitForSeconds(0.25f);//el proceso se ejecutara cada cuarto de segundo
        }
    }
}
