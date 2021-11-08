using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class first : MonoBehaviour
{
    bool isballintheground = true;

    private int goldCoins;
    private int goldCoinCount = 4;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI winText;
    private GameObject scoreObject;

    private void Start() {
        scoreText.text = "Score: 0";
        scoreObject = GameObject.Find("scoreObject");
        scoreObject.GetComponent<scoreKeeper>().score = 0;
        
    }

    void Update()
    {
        Camera.main.transform.position = new Vector3(this.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isballintheground)
            {
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 500, 0));
                isballintheground = true;
            }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform>().position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Transform>().position += new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Transform>().position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Transform>().position += new Vector3(0, 0, -0.1f);
        }
        if (this.transform.position.y < -5) 
        {
            SceneManager.LoadScene("end");
        }
    }
    
    void OnTriggerEnter(Collider col) {
        scoreObject.GetComponent<scoreKeeper>().score += col.gameObject.GetComponent<coinscript>().point;
        scoreText.text = "Score: " + scoreObject.GetComponent<scoreKeeper>().score;
        goldCoins += col.gameObject.GetComponent<coinscript>().point == 2 ? 1 : 0;
        Destroy(col.gameObject);
        if (goldCoins == goldCoinCount) {
            win();
        }
    }

    public void win() {
        winText.gameObject.SetActive(true);
    }
}


