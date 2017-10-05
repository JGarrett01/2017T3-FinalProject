using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerMovement : MonoBehaviour
{

    public float speed;
    public Vector3 mousePos;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Forward movement
        this.transform.position += transform.forward * Time.deltaTime * speed;

     // Player Controls
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray touchRay = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                RaycastHit hit;
                if (Physics.Raycast(touchRay, out hit))
                {
                    //move to position
                    this.transform.Translate(hit.point * speed);
                }

            }
        }


        speed += 5 * Time.deltaTime;

        if (speed >= 45)
        {
            speed = 45;
        }
    }
}


    
       