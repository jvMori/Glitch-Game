using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        print(PlayerPrefsManager.IsLevelUnlocked(1));
        PlayerPrefsManager.UnlockLevel(1);
        print(PlayerPrefsManager.IsLevelUnlocked(1));


        print(PlayerPrefsManager.GetDifficulty());
        PlayerPrefsManager.SetDifficulty(1);
        print(PlayerPrefsManager.GetDifficulty());

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
