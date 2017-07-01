using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {


    public AudioClip[] levelMusicChangeArray;
    private AudioClip currentLevelMusic;
    private AudioSource audioSource;

    private LevelManager levelManager;
    

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += this.OnLoadCallback;

    }
    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();
        
    }
    
    void OnLoadCallback(Scene scene, LoadSceneMode sceneMode)
    {
        int currIndx = SceneManager.GetActiveScene().buildIndex;
        currentLevelMusic = levelMusicChangeArray[currIndx];

        if (currentLevelMusic)
        {
            audioSource.clip = currentLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

   
}
