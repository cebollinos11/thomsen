using UnityEngine;
using System.Collections;

public class turret : MonoBehaviour {

    Transform player;
    public GameObject missile;
    public float FireRate;
    public GameObject barrel;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        StartCoroutine(handleFire());
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);
	}


    void CheckIfCanShoot() {

        Instantiate(missile,barrel.transform.position,barrel.transform.rotation);
    
    }

    IEnumerator handleFire() {

        do
        {

            yield return new WaitForSeconds(FireRate);
            CheckIfCanShoot();



        } while (true);
        
    
    
    }
}
