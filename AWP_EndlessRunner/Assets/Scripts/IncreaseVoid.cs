using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseVoid : MonoBehaviour
{
    
    public GameObject deathVoid;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deathVoid.gameObject.transform.localScale += new Vector3(1 + Time.deltaTime, 0, 1);
    }

}
