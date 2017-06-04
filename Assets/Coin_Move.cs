using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Move : MonoBehaviour {

    public float speed = 150f;
    Vector2 scale;
    //GameObject candy;

	// Use this for initialization
	void Start () {
        scale = transform.localScale;
        //candy.SendMessage("Makecandy", transform.position, SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);          
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "candy")
        {
            if(speed > 30)
                speed -= 5;
            scale.x += 1.0f;
            scale.y += 1.0f;
            transform.localScale = scale;
            Destroy(collision.gameObject);
            print(collision.gameObject.tag);
            print("collision !!!\n");
        }
        print(collision.gameObject.tag);
    }

}
