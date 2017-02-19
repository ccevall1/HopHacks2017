using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartControl : MonoBehaviour {
    private float timer;
    public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        transform.localScale = new Vector3(1f+0.05f*Mathf.Sin(speed*timer), 1f + 0.05f * Mathf.Sin(speed * timer), 1f + 0.05f * Mathf.Sin(speed * timer));
	}

    public void OnButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}
