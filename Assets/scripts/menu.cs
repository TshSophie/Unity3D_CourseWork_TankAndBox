using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowMenu()
    {
        SceneManager.LoadScene("menu");
    }


    public void GameAgain()
    {
        SceneManager.LoadScene("running01");
    }


    public void GameExit()
    {
        Application.Quit();
    }


}
