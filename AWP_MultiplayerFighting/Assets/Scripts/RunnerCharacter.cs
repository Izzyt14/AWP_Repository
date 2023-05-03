using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerCharacter : MonoBehaviour
{

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3 (1, 0, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
