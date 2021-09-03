using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Menu : MonoBehaviour
{
    public void playButton()
    {
        int levelOne = SceneManager.GetActiveScene().buildIndex +1;
        SceneManager.LoadScene(levelOne);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
