using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
        public float speed = 3.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += speed * transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position -= speed * transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += speed * transform.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position -= speed * transform.right * Time.deltaTime;
    }


}
