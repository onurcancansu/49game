using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    public Scoring1 S;
    // Start is called before the first frame update
    void Start()
    {
        S = GameObject.Find("Canvas").GetComponent<Scoring1>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, 2));
        
    }
    private void OnTriggerEnter(Collider other)
    {
        S.score++;
        Destroy(gameObject);
    }
}
