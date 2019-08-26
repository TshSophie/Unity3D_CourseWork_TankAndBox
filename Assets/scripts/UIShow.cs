using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIShow : MonoBehaviour {

    public Text showScoreText;
    public Text showLifeText;
    public Slider showLifeSlider;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        float score = PlayerPrefs.GetFloat("Score");
        float life = PlayerPrefs.GetFloat("Life");
        showScoreText.text = "Score: "+ score;       
        showLifeText.text = "Life: "+life ;
        showLifeSlider.value = life;
    }


}
