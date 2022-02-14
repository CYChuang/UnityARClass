using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ClickButton : MonoBehaviour
{
    public Animator model;
    VirtualButtonBehaviour[] buttonarray;

    // Start is called before the first frame update
    void Start()
    {
        model.GetComponent<Animator>();

        buttonarray = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i< buttonarray.Length; i++) 
        {
            buttonarray[i].RegisterOnButtonPressed(OnButtonPressed);
            buttonarray[i].RegisterOnButtonReleased(OnButtonReleased);

            Debug.Log("button set");
        }

    }
    public void OnButtonPressed(VirtualButtonBehaviour obj)
    {
        Debug.Log("OnButtonPressed");
        model.SetTrigger("Die") ;
       
    }

    private void OnButtonReleased(VirtualButtonBehaviour obj)
    {
        Debug.Log("OnButtonRelease");
        //model.Play("Bee_ani|Fly");
        
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
