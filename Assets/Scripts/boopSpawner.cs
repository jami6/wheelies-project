using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boopSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] boopReference;

    private  GameObject spawnedBoop;

    [SerializeField]
    private Transform Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8, Pos9, Pos10, Pos11;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBoops());
    }

    // 
    IEnumerator SpawnBoops()
    {
        while(true){
            yield return new WaitForSeconds(Random.Range(1, 2));
        
            randomIndex = Random.Range(0, boopReference.Length);
            randomSide = Random.Range(0, 11);

            spawnedBoop = Instantiate(boopReference[randomIndex]);

            if(randomSide==0){
                spawnedBoop.transform.position = Pos1.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==1){
                spawnedBoop.transform.position = Pos2.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==2){
                spawnedBoop.transform.position = Pos3.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==3){
                spawnedBoop.transform.position = Pos4.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==4){
                spawnedBoop.transform.position = Pos5.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==5){
                spawnedBoop.transform.position = Pos6.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==6){
                spawnedBoop.transform.position = Pos7.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==7){
                spawnedBoop.transform.position = Pos8.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==8){
                spawnedBoop.transform.position = Pos9.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else if(randomSide==9){
                spawnedBoop.transform.position = Pos10.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }
            else{
                spawnedBoop.transform.position = Pos11.position;
                spawnedBoop.GetComponent<boop>().speed = -Random.Range(6, 10);
            }

        } //end while loop

    }

}  //class
