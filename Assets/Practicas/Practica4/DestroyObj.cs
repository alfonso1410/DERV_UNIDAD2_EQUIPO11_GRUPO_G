using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyObj : MonoBehaviour
{
      
    [SerializeField] TextMeshProUGUI txt_contador;
    [SerializeField] TextMeshProUGUI txt_con;
    public int contadorbanana, contadormanzana;
    public void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("Enemy")){
            Destroy(obj);
            contadorbanana++;
            txt_contador.text = contadorbanana.ToString();
        }
        else if(obj.CompareTag("Enemy2")){
            Destroy(obj);
            contadormanzana++;
            txt_con.text = contadormanzana.ToString();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      contadorbanana = 0;
      contadormanzana = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
