using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_Candy : MonoBehaviour {

    public Transform candy;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Network.isServer)
            MakeCandy();
    }

    void MakeCandy()
    {
        if (UnityEngine.Random.Range(0, 1000) > 950)
            Instantiate(candy);
    }

   /* IEnumerator Makecandy()//연료 감소 메소드
    {
        if (UnityEngine.Random.Range(0, 1000) > 600)
            Instantiate(candy);

        yield return new WaitForSeconds(1.0f);//해당 메소드에 1초 지연을 시킨다.
        
    }*/
}
