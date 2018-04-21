using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEggDrop : MonoBehaviour
{
    public GameObject eggToDrop = null;
    public int numOfEnemies = 0;
    public float dropTimeInterval = 0;
    private int enemyCounter = 0;

    public float minX, maxX;
    public float minY, maxY;
    public float minZ, maxZ;

    private Vector3 randSpawnVec3;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("DropEggRandomly", dropTimeInterval, 1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemyCounter == numOfEnemies)
        {
            CancelInvoke("DropEggRandomly");
        }
    }

    void DropEggRandomly()
    {
        Instantiate(eggToDrop, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), eggToDrop.transform.rotation);
        enemyCounter++;
    }
}
