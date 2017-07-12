using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";


    public static void SetMasterVolume(float volume)
    {
        if (volume > 0f && volume < 1f)
        {
        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        } else
        {
            Debug.LogError("Volume out of range!");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level)
    {
        if (level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("Level number out of total level count in build");
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool isLevelUnlocked = levelValue == 1f;

        if ( level <= SceneManager.sceneCountInBuildSettings -1 )
        {
            return isLevelUnlocked;
        }
        else
        {
            Debug.LogError("Get number between 0 and count of levels");
            return false;
        }
    }

    public static void SetDifficulty(float volume)
    {
        if (volume > 0f && volume < 1f)
        { 
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Difficulty volume out of range");
        }

    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
}
