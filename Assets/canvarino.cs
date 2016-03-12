using UnityEngine;
using System.Collections;

public class canvarino : MonoBehaviour {


    public GameObject bday;
    public GameObject superhot;

	// Use this for initialization
	void Start () {
        bday.SetActive(false);


        StartCoroutine(scripterino());
	}

    IEnumerator scripterino() {

        yield return new WaitForSeconds(5f);
    

    bday.SetActive(true);
    superhot.SetActive(false);
    
    }
}
