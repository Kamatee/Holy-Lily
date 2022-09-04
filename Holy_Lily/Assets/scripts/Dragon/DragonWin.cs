using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWin : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject gems;
    
    void Start()
    {
        pointsToWin = gems.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentPoints >= pointsToWin)
        {
            //tutaj wywo³aæ panel
            Debug.Log("wygra³eœ");
            //ustawia napis na panelu
            transform.GetChild(0).gameObject.SetActive(true);
            
        }
    }

    public void AddPoints()
    {
        currentPoints++;
        Debug.Log("liczba punktów: " + currentPoints);
    }
}
