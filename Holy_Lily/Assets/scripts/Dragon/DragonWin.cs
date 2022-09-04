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
            //tutaj wywo�a� panel
            Debug.Log("wygra�e�");
            //ustawia napis na panelu
            transform.GetChild(0).gameObject.SetActive(true);
            
        }
    }

    public void AddPoints()
    {
        currentPoints++;
        Debug.Log("liczba punkt�w: " + currentPoints);
    }
}
