using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class END : MonoBehaviour
{
    public void EndGame() { }
    
    public static END instance = null;
    public GameObject WINText;
    public float resetdelay;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }
    public void Win()
    {
        WINText.SetActive(true);
        Time.timeScale = .5f;
        Invoke("Reset", resetdelay);
    }

    [System.Obsolete]
    void Reset()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel (Application.loadedLevel);
    }
}
