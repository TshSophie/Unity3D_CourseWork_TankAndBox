
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxEvent : MonoBehaviour {
    //分数
    public static float Score = 0;
    //生命值
    public static float Life = 5;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Score == 100)
        {
            print("you win");           
            PlayerPrefs.SetFloat("Score", 0);
            PlayerPrefs.SetFloat("Life", 5);
            Score = 0;
            Life = 5;
            SceneManager.LoadScene("win");
        }
        if (Life <= 0)
        {
            print("game over");           
            PlayerPrefs.SetFloat("Score", 0);
            PlayerPrefs.SetFloat("Life", 5);
            Score = 0;
            Life = 5;
            SceneManager.LoadScene("lost");
        }
    }


    private void OnCollisionEnter(Collision collision)
    {       
        if (collision.gameObject.tag == "tank")
        {
            //坦克被盒子碰到了，游戏结束
            SceneManager.LoadScene("lost");
            PlayerPrefs.SetFloat("Score", 0);
            PlayerPrefs.SetFloat("Life", 5);
            Score = 0;
            Life = 5;
        }
        else
        {
            if (collision.gameObject.tag == "bullet")
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                //坦克被盒子碰到了，+10分
                Score += 10;
                //将分数缓存
                PlayerPrefs.SetFloat("Score", Score);
            }

            if (collision.gameObject.tag == "wall")
            {
                Destroy(this.gameObject);
                //让盒子进入到禁地了扣5分，同时生命值-1
                Score -= 5;
                Life -= 1;
                //将分数缓存
                PlayerPrefs.SetFloat("Score", Score);
                PlayerPrefs.SetFloat("Life", Life);

            }
        }
    }
       
}
