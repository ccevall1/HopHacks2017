using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreenControl : MonoBehaviour {
    private float timer;
    public float loadTime;
    private Text title;

	// Use this for initialization
	void Start () {
        timer = 0.00001f;
        title = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer < 0.5f*loadTime)
        {
            title.color = new Color(0, 0, 0, (2 * timer / loadTime));
        }
        else
        {
            if (timer >= loadTime)
            {
                SceneManager.LoadScene(1);
            }
        }
	}

}
