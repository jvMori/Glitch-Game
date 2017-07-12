using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

    public float fadeInTime;

    private Image fadePanel;
    private Color currentColor = Color.black;


	// Use this for initialization
	void Start () {
        fadePanel = GetComponent<Image>();
        fadeInTime = 3f;
	}

    private void Update()
    {
        if (Time.timeSinceLevelLoad < fadeInTime)
        {
            //fade in
            float alphaChange = Time.deltaTime / fadeInTime;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
