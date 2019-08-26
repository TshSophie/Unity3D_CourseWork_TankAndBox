using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCreate : MonoBehaviour {
    public Rigidbody[] Box;
    private Rigidbody box;
    // Use this for initialization
    void Start () {

        InvokeRepeating("CreateBox", 1, 3);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void CreateBox()
    {
        float x = Random.Range(-4,4);
        int i = Random.Range(0, 3);
        box = Instantiate(Box[i]);
        box.transform.position = new Vector3(x,0.75f,10);
        box.AddForce(new Vector3(0, 0, -1) * 10, ForceMode.Impulse);
    }
}
