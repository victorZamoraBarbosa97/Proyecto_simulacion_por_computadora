using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   public void DoQuit()
    {
        Debug.Log("Haz salido del juego");
        Application.Quit();
    }
   
}
