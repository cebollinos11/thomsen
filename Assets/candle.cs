using UnityEngine;
using System.Collections;

public class candle : MonoBehaviour {

    public AudioClip pickup;
    public GameObject exploPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col) {

        Debug.Log("candle");

        if (col.gameObject.tag == "Player")
        {
            GameObject explo = (GameObject)Instantiate(exploPrefab, transform.position, transform.rotation);
            explo.transform.localScale *= 10f;
            AudioManager.PlaySpecific(pickup);
            Object.FindObjectOfType<GameManager>().CollectCake();
            Destroy(this.gameObject);
        }
    
    }
}
