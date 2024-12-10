using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersDetect : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        Debug.Log("Enter"+ other.gameObject.name);
    }

    private void OnTriggerStay(Collider other){
        Debug.Log("Stay"+ other.gameObject.name);
    }

    private void OnTriggerExit(Collider other){
        Debug.Log("Exit"+ other.gameObject.name);
    }
}
