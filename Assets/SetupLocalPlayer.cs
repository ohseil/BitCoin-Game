using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{

    // Use this for initialization
    void Start()
    {

        if (isLocalPlayer)
            GetComponent<Coin_Move>().enabled = true;
    }


}
