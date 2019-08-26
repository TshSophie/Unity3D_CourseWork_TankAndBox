using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginEvent : MonoBehaviour {
    public InputField Username;
    public InputField Password;
    public GameObject Manu;
    public GameObject Note;
    public Text error;
    private AudioSource audioSource;
   
    // Use this for initialization
    void Start () {
        //获取音频组件
        audioSource = GetComponent<AudioSource>();
    }
    public void GotoNote()
    {
        if (Username.text == "sophie" && Password.text == "123456")
        {
            //显示说明
            Note.gameObject.SetActive(true);
            //播放音乐
            audioSource.Play();
        }
        else
        {
            //InputAgain.gameObject.SetActive(true);
            error.text = "用户名或密码错误，请重新输入";            
        }
        
    }

    public void GotoMenu()
    {
        //显示菜单       
        SceneManager.LoadScene("menu");

    }

    public void GameLevel01(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
