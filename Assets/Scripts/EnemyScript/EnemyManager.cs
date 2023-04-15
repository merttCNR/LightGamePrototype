using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    float randomNumb;
    //public bool isRightlook;
    GameObject index;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLocation",2,10);
    }

    // Update is called once per frame
    void Update()
    {
        RandomGenerator();
        SpawnEnemy();
    }
    private void RandomGenerator(){
        randomNumb = Random.Range(0,90);
    }
    private void SpawnEnemy(){
        if(randomNumb >= 0 && randomNumb <= 30){
            //red
            index = enemyPrefabs[0];
        }
        else if(randomNumb >= 31 && randomNumb <= 60){
            //yellow
            index = enemyPrefabs[1];
        }
        else if(randomNumb >= 61 && randomNumb <= 90){
            //green
            index = enemyPrefabs[2];
        }
    }
    private void SpawnLocation(){ 
       //if(randomNumb >= 0 && randomNumb <= 45){
            Instantiate(index,new Vector2(transform.position.x,0.4f),Quaternion.Euler(0,-180,0));
       // }
    }
    /*
    private void SpawnLocation(){
        if(randomNumb >= 0 && randomNumb <= 45){
            Instantiate(index,new Vector2(transform.position.x,0.4f),Quaternion.Euler(0,-180,0));
            isRightlook = false;
        }
        else if(randomNumb >= 46 && randomNumb <= 90){
            Instantiate(index,new Vector2(-transform.position.x,0.4f),Quaternion.identity);
            isRightlook = true;
        }
    }*/
}
