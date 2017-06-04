using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy_Effect : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        InitCandy();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void InitCandy()
    {
        float x = Random.Range(0, 470);
        float y = Random.Range(0, 470);
        transform.position = new Vector2(x, y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      /*  if (collision.gameObject.tag == "BitCoin")
        {
            Destroy(this);
            print("collision !!!\n");
        }*/
    }
}
