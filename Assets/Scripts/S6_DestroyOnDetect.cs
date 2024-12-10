using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S6_DestroyOnDetect : MonoBehaviour
{

    
    [SerializeField] TextMeshProUGUI txt_contador;
    int contador;
    private void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("Enemy")){
            Destroy(obj);
            contador++;
            txt_contador.text = contador.ToString();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
