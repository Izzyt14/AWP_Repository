using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputHole : MonoBehaviour
{
    
    Rigidbody2D rb;
    Vector3 currentPosition;
    public GameObject outputHole;
    public GameObject redBox;
    public GameObject greenBox;
    public GameObject pinkBox;
    public bool isActivated2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isActivated2 = false;
        redBox = GameObject.Find("Red Box");
        greenBox = GameObject.Find("Green Box");
        pinkBox = GameObject.Find("Pink Box");
        StartCoroutine("ResetBoxes");
    }

    // Update is called once per frame
    //void Update()
    //{
        //currentPosition = outputHole.transform.position;
    //}

    public void expelRedBox(){
        GameObject RedBox = Instantiate(redBox, currentPosition, Quaternion.identity);
        RedBox.name = "Red Box";
        redBox.GetComponent<RedBox>().enabled = true;
    }

    public void expelGreenBox(){
        GameObject GreenBox = Instantiate(greenBox, currentPosition, Quaternion.identity);
        GreenBox.name = "Green Box";
        greenBox.GetComponent<GreenBox>().enabled = true;
    }
    
    public void expelPinkBox(){
        GameObject PinkBox = Instantiate(pinkBox, currentPosition, Quaternion.identity);
        PinkBox.name = "Pink Box";
        pinkBox.GetComponent<PinkBox>().enabled = true;
    }

    void Reset(){
        redBox = GameObject.Find("Red Box");
        greenBox = GameObject.Find("Green Box");
        pinkBox = GameObject.Find("Pink Box");
    }

    public IEnumerator ResetBoxes(){
        while(true){
        yield return new WaitForSeconds(0.1f);
        Reset();
        yield return new WaitForSeconds(1.0f);
        }
    }
    
    private void Update() {
        if (isActivated2 == true){
         if (Input.GetKey(KeyCode.A))
             rb.AddForce(Vector3.left);
         if (Input.GetKey(KeyCode.D))
             rb.AddForce(Vector3.right);
         if (Input.GetKey(KeyCode.W))
             rb.AddForce(Vector3.up);
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector3.down);
        }
 
        currentPosition = outputHole.transform.position;
    
        if (Input.GetKey(KeyCode.Space)){
            if (isActivated2 == false){
            isActivated2 = true;
        } else {
            isActivated2 = false;
        }
    
        }
    
    }


}
