using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_rotacion : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float angulo = 5f * speed * Time.deltaTime;
        transform.Rotate(0,angulo,0);
    }
}
