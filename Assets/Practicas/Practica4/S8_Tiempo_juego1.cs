using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S8_Tiempo_juego1 : MonoBehaviour
{
   // Start is called before the first frame update
    [SerializeField] CambioEscena auxiliar; //se ocupa vincular el componente por el inspector
    [SerializeField] DestroyObj acceso_score;
    int contador_segundos;
    [SerializeField] TextMeshProUGUI TextoTiempo;
    void Start()
    {
        contador_segundos = 40;
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
            yield return new WaitForSeconds(1f);//el proceso se ejecutara cada cuarto de segundo
        }
        Debug.Log("El juego termino");
        int score = acceso_score.contadorbanana;
        int score2 = acceso_score.contadormanzana;
        score = score+score2;
        auxiliar.cambioEscena(2, score); //escena fin
    }
}
