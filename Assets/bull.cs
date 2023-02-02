using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bull : MonoBehaviour
{
    //public Text GameOverText;
    public Rigidbody2D MyRigidbody;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.UpArrow) == true)
        {
            MyRigidbody.velocity = Vector3.up * 10;
            
        }

        if(transform.position.y < -3.305038)
        {
            text.text = "I'm in the ground";
        }else{
            text.text = " ";
        }
    }
}