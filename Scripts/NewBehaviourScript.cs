﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            FindObjectOfType<audioManager>().Stop("walking");
            FindObjectOfType<audioManager>().Stop("running");
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            FindObjectOfType<audioManager>().Play("walking");
            FindObjectOfType<audioManager>().Stop("running");

            if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {
                FindObjectOfType<audioManager>().Play("running");
                FindObjectOfType<audioManager>().Stop("walking");

            }
        }
        //else
        //{
        //    FindObjectOfType<audioManager>().Stop("walking");
        //}
    }
}




        //geluid gedeelte ------------------------------------------------------------------------------------------------
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("code werkt niet ");
        //    FindObjectOfType<audioManager>().Play("walking");
        //}
        //else
        //{
        //    FindObjectOfType<audioManager>().Stop("walking");
        //}

    //    if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
    //    {
    //        noInput = true;
    //        speed = 0f;
    //        isWalking = false;
    //    }
    //    else
    //    {
    //        walkingsound();
    //        noInput = false;
    //    }

    //    if (speed == 12f)
    //    {
    //        isWalking = true;
    //        isRunning = false;
    //    }
    //    if (speed >= 13f)
    //    {
    //        isRunning = true;
    //        isRunning = false;
    //    }


    //}
    //private void walkingsound()
    //{
    //    if(noInput == false && isWalking)
    //    {
    //        FindObjectOfType<audioManager>().Play("walking");
    //    }
    //    else
    //    {
    //        FindObjectOfType<audioManager>().Stop("walking");
    //    }
    

