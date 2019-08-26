using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTank : MonoBehaviour {

    private float speed = 5f;
  
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {    
        
        //判断坦克的位置，如果坦克处于可活动范围则激活移动键
        //否则把坦克弹回可移动范围去
        if (-11 < transform.position.x && transform.position.x < -3 && -12 < transform.position.z && transform.position.z < 8)
        {
            
            transform.Translate(Vector3.forward * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
            
            transform.Translate(Vector3.right * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime);

        }
        else if(-11 > transform.position.x)
        {
            transform.position += new Vector3(0.1f,0,0);
        }
        else if (transform.position.x > -3)
        {
            transform.position -= new Vector3(0.1f, 0, 0);
        }
        else if (-12 > transform.position.z)
        {
            transform.position += new Vector3( 0, 0,0.1f);
        }
        else if (transform.position.z > 8)
        {
            transform.position -= new Vector3(0, 0,0.1f);
        }


    }
}
