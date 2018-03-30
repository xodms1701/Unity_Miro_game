using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private int count = 3;
    public Text CountText;

    // Use this for initialization
    void Start()
    {
        CountText.text = "목숨 : " + count.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall"){
            count = count - 1;
            SetCountText();
        }
        if (other.tag == "Pick Up"){
            SceneManager.LoadScene("2_Miro");
        }
    }

    void SetCountText()
    {
        CountText.text = "목숨 : " + count.ToString();
        if (count+1 == 1){
            SceneManager.LoadScene("00_GameOver");
        }
    }

}
