using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnCntrl : MonoBehaviour {

    public GameObject EnemyType1;   
    public bool spawnEnemies;   
    public int maxNumOfEnemies;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform[] spawnPointList;
    

    private int EnemiesCounter;
    private float timerMax = 1f;
    private float timerMin = 0f;
    private float timerResetHolder = 1f; 
   
    private int lvlOfDifficulty;
    private bool difficultySetup = false; 
         
    

	// Use this for initialization
	void Start () {
        spawnEnemies = true;
        EnemiesCounter = 0; 
        maxNumOfEnemies = 0;
        lvlOfDifficulty = 2;
    }
	
	// Update is called once per frame
	void Update ()
    {        
        if (spawnEnemies)
        {
            doEnemyWaves();
        }
    }

  
    void doEnemyWaves()
    {       
            switch (lvlOfDifficulty)
            {
                case 0:
                {
                    if (difficultySetup == false)
                    {
                        timerResetHolder = 3f;
                        maxNumOfEnemies = 30;
                        difficultySetup = true;
                    }

                    if (maxNumOfEnemies > 0)
                    {
                        timerMax -= Time.deltaTime;
                        if (timerMax < timerMin)
                        {
                            EnemiesCounter++;
                            Instantiate(EnemyType1, spawnPointList[Random.Range(0, spawnPointList.Length)]);
                            maxNumOfEnemies--;
                            timerMax = timerResetHolder; // reset timer                          
                        }
                    }
                    else
                    {
                        spawnEnemies = false;
                    }
                    break;
                }
               

                case 1:
                {
                    if (difficultySetup == false)
                    {
                        timerResetHolder = 2f;
                        maxNumOfEnemies = 60;
                        difficultySetup = true;
                    }

                    if (maxNumOfEnemies > 0)
                    {
                        timerMax -= Time.deltaTime;
                        if (timerMax < timerMin)
                        {
                            EnemiesCounter++;
                            Instantiate(EnemyType1, spawnPointList[Random.Range(0, spawnPointList.Length)]);
                            maxNumOfEnemies--;
                            timerMax = timerResetHolder; // reset timer                           
                        }
                    }
                    else
                    {
                        spawnEnemies = false;
                    }
                    break;

                }

            case 2:
                {
                    if (difficultySetup == false)
                    {
                        timerResetHolder = 0.5f;
                        maxNumOfEnemies = 90;
                        difficultySetup = true;
                    }
                    if (maxNumOfEnemies > 0)
                    {
                        timerMax -= Time.deltaTime;
                        if (timerMax < timerMin)
                        {
                            EnemiesCounter++;
                            Instantiate(EnemyType1, spawnPointList[Random.Range(0, spawnPointList.Length)]);
                            maxNumOfEnemies--;
                            timerMax = timerResetHolder; // reset timer                          
                        }
                    }
                    else
                    {
                        spawnEnemies = false;
                    }
                    break;

                }

            case 3:
                {
                    if (difficultySetup == false)
                    {
                        timerResetHolder = 0.2f;
                        maxNumOfEnemies = 300;
                        difficultySetup = true;
                    }

                    if (maxNumOfEnemies > 0)
                    {
                        timerMax -= Time.deltaTime;
                        if (timerMax < timerMin)
                        {
                            EnemiesCounter++;
                            Instantiate(EnemyType1, spawnPointList[Random.Range(0, spawnPointList.Length)]);
                            maxNumOfEnemies--;
                            timerMax = timerResetHolder; // reset timer                          
                        }
                    }
                    else
                    {
                        spawnEnemies = false;
                    }
                    break;
                }
               

            default:
                break;                
            }

        //Debug.Log("Number of Enemies: " + maxNumOfEnemies);


    }

}
