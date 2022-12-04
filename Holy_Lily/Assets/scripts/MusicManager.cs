using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value; //g³oœnoœc gry jest równa wartosci z volumebar
        Save();
    }

    private void Load()
    {
        
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()//zapisuje preferencje gracza
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);//(Keyname,value) valume = float
    }


}
