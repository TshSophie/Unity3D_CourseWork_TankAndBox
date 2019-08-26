using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendBullet : MonoBehaviour {
    //public Rigidbody rigidBody;
    public Rigidbody Bullet;
    private Rigidbody bullet;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bullet = Instantiate(Bullet);
            bullet.transform.position = transform.position;            
            bullet.AddForce(new Vector3(0,0,1)*30,ForceMode.Impulse);            
        }
	}
}
