using UnityEngine;
using System.Collections;

public class candle : MonoBehaviour {

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
            Object.FindObjectOfType<GameManager>().CollectCake();
            Destroy(this.gameObject);
        }
    
    }
}
