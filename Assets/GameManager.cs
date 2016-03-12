using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


    public int collectedCakes;

	// Use this for initialization
	void Start () {
	
	}

    IEnumerator WinGame() {

        yield return new WaitForSeconds(4f);
        Application.LoadLevel(1);
    
    }

    public void CollectCake() {

        collectedCakes++;
        Object.FindObjectOfType<candleCounter>().SetCandles(collectedCakes);

        if (collectedCakes > 26)
        {
            StartCoroutine( WinGame());
        }
    
    }
}
