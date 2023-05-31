using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    // Random position will be the position we want to place the object
    public GameObject ground;
    public Transform runner;
    Vector3 nextPosition;
    
    void Start()
    {
        StartCoroutine("GroundSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        nextPosition = new Vector3(runner.position.x + 30, Random.Range(-2, 2), 0);   //new Vector3(runner.position.x + 30, -3, 0);

    }

    public IEnumerator GroundSpawner(){
        
        while(true){
            yield return new WaitForSeconds(1.0f);
            SpawnGround();
            yield return new WaitForSeconds(1.0f);
            }

        }

    public void SpawnGround(){
        Instantiate(ground, nextPosition, Quaternion.identity);
    }

}
