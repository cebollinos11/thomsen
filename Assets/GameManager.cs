using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


    public int collectedCakes;

	// Use this for initialization
	void Start () {
	
	}

    void WinGame() { 
    
    
    }

    public void CollectCake() {

        collectedCakes++;
        Object.FindObjectOfType<candleCounter>().SetCandles(collectedCakes);

        if (collectedCakes > 26)
        {
            WinGame();
        }
    
    }
}
