using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropEnemyEgg : MonoBehaviour
{
    public GameObject enemyToSpawn;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Ground")
        {
            Invoke("SpawnEnemy", 1);
            Invoke("DestroyEgg", 1);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyToSpawn, transform.position, transform.rotation);
    }

    void DestroyEgg()
    {
        Destroy(this.gameObject);
    }
}
