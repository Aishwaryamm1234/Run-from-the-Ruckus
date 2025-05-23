using System.Collections;
using System.ComponentModel;
using UnityEngine;

public class monsterspawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;
     

    private GameObject spawnedMonster;

   [SerializeField]
   private Transform leftPos,rightPos;

   private int randomIndex;
   private int randomSide;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters(){
        while(true){
            yield return new WaitForSeconds(Random.Range(1,5));

        randomIndex = Random.Range(0,monsterReference.Length);
        randomSide = Random.Range(0,2);

        spawnedMonster = Instantiate(monsterReference[randomIndex]);
         //Left side
        if(randomSide == 0) {
        spawnedMonster.transform.position=leftPos.position;
        spawnedMonster.GetComponent<monster>().speed = Random.Range(4,10);
        }
        else{
         //right side
        spawnedMonster.transform.position=rightPos.position;
        spawnedMonster.GetComponent<monster>().speed = -Random.Range(4,10);
        spawnedMonster.transform.localScale = new Vector3(-1f,1f,1f);
        }
        
        }
    }
   
}
