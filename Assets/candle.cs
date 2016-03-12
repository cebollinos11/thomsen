using UnityEngine;
using System.Collections;

public class candle : MonoBehaviour {

    public AudioClip pickup;

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
            AudioManager.PlaySpecific(pickup);
            Object.FindObjectOfType<GameManager>().CollectCake();
            Destroy(this.gameObject);
        }
    
    }
}
