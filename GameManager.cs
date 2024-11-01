using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
public GameObject player;
public GameObject enemy;
public GameObject enemy2;

// Start is called before the first frame update
void Start()
{
Instantiate(player, transform.position, Quaternion.identity);
InvokeRepeating("CreateEnemy", 1f, 3f);

//CreateEnemy2 and3 by Donovan Peckham
InvokeRepeating("CreateEnemy2", 2f, 6f);
InvokeRepeating("CreateEnemy3", 3f, 5f);
    }



// Update is called once per frame
void Update()
{
       
}
void CreateEnemy()
{
Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 8f, 0),
Quaternion.identity);

}
 //CreateEnemy2 by Donovan Peckham
    void CreateEnemy2()
    {
        Instantiate(enemy2, new Vector3(12f, Random.Range(-6f, 6f), 0),
Quaternion.identity);
    }

    //CreateEnemy3 by Donovan Peckham
    void CreateEnemy3()
    {
        Instantiate(enemy2, new Vector3(Random.Range(-12f, 12f), 8f, 0),
Quaternion.identity);
    }
}
