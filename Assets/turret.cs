using UnityEngine;
using System.Collections;

public class turret : MonoBehaviour {

    Transform player;
    public GameObject missile;
    public float FireRate;
    public GameObject barrel;

    bool playerInRange;

    void Start() {
        player = GameObject.FindGameObjectWithTag("FuturePoint").transform;

        StartCoroutine(handleFire());
    }

    void OnTriggerEnter(Collider col) {


        if (col.gameObject.tag == "Player")
        {
            playerInRange = true;
        }


    
    }


    void OnTriggerExit(Collider col)
    {


        if (col.gameObject.tag == "Player")
        {
            playerInRange = false;
        }



    }
	
	// Update is called once per frame
	void Update () {
        
        transform.LookAt(player);
	}


    void CheckIfCanShoot() {

        if (playerInRange)
        {
            Instantiate(missile, barrel.transform.position, barrel.transform.rotation);
        }
        
    
    }

    IEnumerator handleFire() {

        do
        {

            yield return new WaitForSeconds(FireRate);
            CheckIfCanShoot();



        } while (true);
        
    
    
    }
}
