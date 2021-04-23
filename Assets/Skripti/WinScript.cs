using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int pointsToWin=11;
    private int currentPoints=0;
      

   
    void Update()
    {
        if(currentPoints>=pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void AddPoints(){
        currentPoints++;
    }
}
