using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWin : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject gems;
    [SerializeField] private AudioSource winSoundEffect;

    void Start()
    {
        pointsToWin = gems.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentPoints == pointsToWin)
        {
            //tutaj wywo�a� panel
            //ustawia napis na panelu
            transform.GetChild(0).gameObject.SetActive(true);
            winSoundEffect.Play();
            GameObject.Find("LilyEntrance").GetComponent<DoorsToUnlock>().OpenDoors();
            //tutaj u�y� funkcji kt�ra ma otworzy� drzwi
            AddPoints();


        }
    }

    public void AddPoints()
    {
        currentPoints++;
        Debug.Log("liczba punkt�w: " + currentPoints);
    }
}
