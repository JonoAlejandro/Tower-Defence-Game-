using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Menu : MonoBehaviour
{ 

    public Slider musicSlider;
    public Slider sfxSlider;
    public AudioMixer mixer;

    public void playButton()
    {
        int levelOne = SceneManager.GetActiveScene().buildIndex +1;
        SceneManager.LoadScene(levelOne);
    }
    public void QuitGame()
    {
        Debug.Log("Game Quitting");
        Application.Quit();
    }

    public void SetMusicLevel(float sliderValue)
    {
        mixer.SetFloat("Music Volume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("Music Volume", sliderValue);
    }
    public void SetSFXLevel(float sliderValue)
    {
        mixer.SetFloat("SFX Volume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFX Volume", sliderValue);
    }

    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("Music Volume", 1f);
        sfxSlider.value = PlayerPrefs.GetFloat("SFX Volume", 1f);
        Cursor.visible = true;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
