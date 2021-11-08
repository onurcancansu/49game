using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    bool isballintheground = true;
    // Update is called once per frame
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

        void OnCollisionEnter(Collision col)
        {
            Debug.Log("we collide with" + col.gameObject.name);
            isballintheground = true;
            
            
        }
        int count = 0;
        void OnTriggerEnter(Collider col)
        {
            Debug.Log("we trigger with" + col.gameObject.name);
            col.gameObject.SetActive(false);
            count += 1;
            Debug.Log("current coins" + count.ToString());

        }
    }
}


