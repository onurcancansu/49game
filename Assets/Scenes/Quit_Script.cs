using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_Script : MonoBehaviour
{
    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
