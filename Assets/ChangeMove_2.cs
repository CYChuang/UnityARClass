using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeMove_2 : MonoBehaviour
{
    public GameObject model;
    VirtualButtonBehaviour[] buttonarray;

    // Start is called before the first frame update
    void Start()
    {
        model.GetComponent<Animator>();

        buttonarray = GetComponentsInChildren<VirtualButtonBehaviour>();
        


        for (int i = 0 ; i < buttonarray.Length; i++) 
        {
            buttonarray[i].RegisterOnButtonPressed(OnButtonPress);
        }
    }

    private void OnButtonPress(VirtualButtonBehaviour obj)
    {
        model.GetComponent<Animator>().Play("Bee_ani|Die");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
