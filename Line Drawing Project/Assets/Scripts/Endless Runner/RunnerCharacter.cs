using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerCharacter : MonoBehaviour
{

    public GameObject runner;
    float speed;
    public bool mode;

    // Start is called before the first frame update
    void Start()
    {
        mode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == false){
        float speed = 10;
        Vector3 movement = new Vector3 (1, 0, 0);
        transform.Translate(movement * speed *Time.deltaTime);
        }

        if (mode == true){
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

    public void SwitchToHard(){
        mode = true;
    }

    public void SwitchToEasy(){
        mode = false;
    }

}
