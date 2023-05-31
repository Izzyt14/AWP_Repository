using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerCharacter : MonoBehaviour
{

    public GameObject runner;
    float speed;
    float mode;

    // Start is called before the first frame update
    void Start()
    {
        mode = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (mode == 1){
        float speed = Time.time;
        Vector3 movement = new Vector3 (1, 0, 0);
        transform.Translate(movement * speed * 1);
        }

        if (mode == 2){
        float speed = Time.time;
        Vector3 movement = new Vector3 (1, 0, 0);
        transform.Translate(movement * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log(speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Death Void")
        {
            Destroy(runner);
        }
    }

    void SwitchToHard(){
        mode = 2;
    }

    void SwitchToEasy(){
        mode = 1;
    }


}
