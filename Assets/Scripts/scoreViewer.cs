using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreViewer : MonoBehaviour {
    private GameObject scoreObject;
    private void Start() {
        
        scoreObject = GameObject.Find("scoreObject");
        this.GetComponent<Text>().text = "Total score: " + scoreObject.GetComponent<scoreKeeper>().score;
    }
}
