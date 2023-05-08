using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHole : MonoBehaviour
{
    
    Rigidbody2D rb;
    public bool isActivated1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isActivated1 = true;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

     private void Update() {
        if (isActivated1 == true){
         if (Input.GetKey(KeyCode.A))
             rb.AddForce(Vector3.left);
         if (Input.GetKey(KeyCode.D))
             rb.AddForce(Vector3.right);
         if (Input.GetKey(KeyCode.W))
             rb.AddForce(Vector3.up);
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector3.down);
        }
 
        if (Input.GetKey(KeyCode.Space)){
            if (isActivated1 == false){
            isActivated1 = true;
        } else {
            isActivated1 = false;
        }

        }
    }



}
