using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playpiano : MonoBehaviour
{
    GameObject Key;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
		Key = GameObject.Find(hit.transform.name);
 		Key.GetComponent<AudioSource>().Play();

            } 
        }
        
    }
}
