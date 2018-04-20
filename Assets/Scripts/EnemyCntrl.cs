using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCntrl : MonoBehaviour {

    public GameObject cargo;
    public GameObject player1;
    public GameObject player2; 
    public float speed;

    private float p1Dis;
    private float p2Dis;
    private float cargoDis;
    Vector3 targetPosition; 

    // Use this for initialization
    void Start () {
        speed = 5f;       
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        cargo = GameObject.FindGameObjectWithTag("Cargo");
    }
	
	// Update is called once per frame
	void Update () {

        float step = speed * Time.deltaTime;
        calcTargetDistances(); 
      
        this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, step);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cargo")
        {
            Destroy(this.gameObject); 
        }

        if (other.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
        }
    }

    void calcTargetDistances()
    {
        p1Dis = Vector3.Distance(this.transform.position, player1.transform.position);
        p2Dis = Vector3.Distance(this.transform.position, player2.transform.position);
        cargoDis = Vector3.Distance(this.transform.position, cargo.transform.position);

        if(p1Dis < p2Dis && p1Dis < cargoDis)
        {
            targetPosition = new Vector3(player1.transform.position.x, player1.transform.position.y, player1.transform.position.z); 
        }

        else if (p2Dis < p1Dis && p2Dis < cargoDis)
        {
            targetPosition = new Vector3(player2.transform.position.x, player2.transform.position.y, player2.transform.position.z);
        }

        else
        {
            targetPosition = new Vector3(cargo.transform.position.x, cargo.transform.position.y, cargo.transform.position.z);
        }
    }
}
