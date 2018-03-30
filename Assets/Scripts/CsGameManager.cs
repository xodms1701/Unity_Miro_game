using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsGameManager : MonoBehaviour {

	 public Text splash_text;
     public Image splash_img;
    // Use this for initialization
    void Start () {
     
    }
     
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            Text.Destroy(splash_text);
            Image.Destroy(splash_img);
        }
    }
}
