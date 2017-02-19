using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public TextAsset CatPunspiration;
    public Sprite[] CatPics;
    private Image Picture;
    private Text Pun;
    private string[] PunString;
    private Image mask;
    private float timer;
	// Use this for initialization
	void Start () {
        Picture = GameObject.Find("CatPicture").GetComponent<Image>();
        Pun = GameObject.Find("Textbox").GetComponent<Text>();
        PunString = CatPunspiration.text.Split('\n');
        mask = GameObject.Find("Mask").GetComponent<Image>();
        timer = 1;
	}
	
	// Update is called once per frame
	void Update () {
	    if (timer > 0)
        {
            timer -= Time.deltaTime;
            mask.color = new Color(255, 255, 255, timer);
        }
        else
        {
            Destroy(mask.gameObject);
        }
	}
    public void onButtonClicked()
    {
        int indexPun = Random.Range(0, PunString.Length);
        int indexCatPic = Random.Range(0,CatPics.Length);
        while (PunString[indexPun] == "")
        {
            indexPun = Random.Range(0, PunString.Length);
        }
            Picture.sprite = CatPics[indexCatPic];
            Pun.text = PunString[indexPun];
        
        }
}
