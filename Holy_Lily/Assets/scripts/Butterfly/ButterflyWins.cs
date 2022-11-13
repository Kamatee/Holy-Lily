using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyWins : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject butterflies;
    [SerializeField] private AudioSource winSoundEffect;

    void Start()
    {
        pointsToWin = butterflies.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints == pointsToWin)
        {
            //tutaj wywo³aæ panel
            //ustawia napis na panelu
            transform.GetChild(0).gameObject.SetActive(true);
            winSoundEffect.Play();
            AddPoints();


        }
    }

    public void AddPoints()
    {
        currentPoints++;
        Debug.Log("liczba punktów: " + currentPoints);
    }
}
