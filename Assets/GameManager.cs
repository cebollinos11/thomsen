using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


    public int collectedCakes;

	// Use this for initialization
	void Start () {
	
	}

    IEnumerator WinGame() {

        yield return new WaitForSeconds(4f);
        Application.LoadLevel(2);
    
    }

    IEnumerator DoLag() {

        Time.timeScale = 0.3f;
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 1f;
    
    }

    public void CollectCake() {

        collectedCakes++;
        Object.FindObjectOfType<candleCounter>().SetCandles(collectedCakes);

        if (collectedCakes > 26)
        {
            StartCoroutine( WinGame());
        }

        StartCoroutine(DoLag());
    
    }
}
