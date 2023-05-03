using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerCharacter : MonoBehaviour
{

    float speed;
    public float jumpHeight = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Time.time;
        Vector3 movement = new Vector3 (1, 0, 0);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log(speed);
        }
    }
}
