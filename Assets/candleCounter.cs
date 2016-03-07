using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class candleCounter : MonoBehaviour {

    public void SetCandles(int i) {
        GetComponent<Text>().text = i.ToString() + "/27";
    }
}
