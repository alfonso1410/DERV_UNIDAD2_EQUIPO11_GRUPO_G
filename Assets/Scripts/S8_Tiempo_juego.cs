using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S8_Tiempo_juego : MonoBehaviour
{
   // Start is called before the first frame update
    [SerializeField] CambioEscena auxiliar; //se ocupa vincular el componente por el inspector
    [SerializeField] S9_DestruyeObjetosReforma acceso_score;
    int contador_segundos;
    [SerializeField] TextMeshProUGUI TextoTiempo;
    void Start()
    {
        contador_segundos = 10;
        TextoTiempo.text = contador_segundos.ToString();
        StartCoroutine("corrutinaTiempo");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator corrutinaTiempo(){
        while(contador_segundos >= 0){
            TextoTiempo.text = contador_segundos--.ToString();
            yield return new WaitForSeconds(0.25f);//el proceso se ejecutara cada cuarto de segundo
        }
        Debug.Log("El juego termino");
        int score = acceso_score.contador;
        auxiliar.cambioEscena(2, score); //escena fin
    }
}
