using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSetting : MonoBehaviour
{
    [SerializeField] private Slider sfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }

    public void SetVolumePref()
    {
        PlayerPrefs.SetFloat("SFXVolume", sfxSlider.value);
    }

}
