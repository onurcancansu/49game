using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {
    private Vector3 position;
    private Vector3 upperPosition;

    private Rigidbody wallRB;

    [SerializeField] private float time;
    [SerializeField] private float distance;

    private bool goingUp = true;

    // Start is called before the first frame update
    void Start() {
        if (this.gameObject.GetComponent<Rigidbody>() == null) {
            this.gameObject.AddComponent<Rigidbody>();
        }
        
        position = transform.position;
        wallRB = this.gameObject.GetComponent<Rigidbody>();
        wallRB.useGravity = false;
        upperPosition = position + distance * Vector3.up;

        StartCoroutine(moveCoroutine());
    }

    IEnumerator moveCoroutine() {
        float velocity = distance / time;

        if (goingUp) {
            wallRB.velocity = velocity * Vector3.up;
        } else {
            wallRB.velocity = velocity * Vector3.down;
        }

        yield return new WaitForSeconds(time);
        goingUp = !goingUp;
        StartCoroutine(moveCoroutine());
    }
}
