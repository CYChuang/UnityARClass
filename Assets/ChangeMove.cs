using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMove : MonoBehaviour
{
    public Button button;
    public GameObject model;
    public bool isDie;
    
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(delegate { btnclick(); });
    }

    private void btnclick()
    {
        if (isDie == false)
        {
            isDie = true;
            model.GetComponent<Animator>().Play("Bee_ani|Die");
        }
        else 
        {
            isDie = false;
            model.GetComponent<Animator>().Play("Bee_ani|Fly");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
