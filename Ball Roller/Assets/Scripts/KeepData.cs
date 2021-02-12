using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepData : MonoBehaviour
{
    //Renderer rend;
    Vector3 biggerBall = new Vector3(2, 2, 2);

    public void keepColor()
    {
        GameObject player = GameObject.FindWithTag("Player");
        //rend = player.GetComponent<Renderer>();
        //rend.sharedMaterial.SetColor("Color", ColorSelector.playerColor);
    }

    public void bigBall(bool newValue)
    {
        GameObject player = GameObject.FindWithTag("Player");
        player.transform.localScale = biggerBall;
    }
}
