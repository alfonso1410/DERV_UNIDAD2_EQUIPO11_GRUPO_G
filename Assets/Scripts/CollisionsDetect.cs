using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsDetect : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnCollisionEnter(Collision other){
        Debug.Log("Enter"+ other.gameObject.name);
    }

    private void OnCollisionStay(Collision other){
        Debug.Log("Stay"+ other.gameObject.name);
    }

    private void OnCollisionExit(Collision other){
        Debug.Log("Exit"+ other.gameObject.name);
    }

}
