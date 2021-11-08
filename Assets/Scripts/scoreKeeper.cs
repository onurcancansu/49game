using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeper : MonoBehaviour {
    public int score = 0;

    private void Start() {
        DontDestroyOnLoad(this.gameObject);
    }
}
