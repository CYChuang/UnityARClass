using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonclick : MonoBehaviour
{
    public GameObject model;
    public Button button;
    bool Die;

        
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(delegate{ btnclick(); });
        
    }

    private void btnclick()
    {
        switch (Die) 
        { 
            case false:
                Die = true;
                model.GetComponent<Animator>().Play("Bee_ani|Die");
                break;
            case true:
                Die = false;
                model.GetComponent<Animator>().Play("Bee_ani|Fly");
                break;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
