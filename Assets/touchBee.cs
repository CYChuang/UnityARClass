using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchBee : MonoBehaviour
{
    public int number;
    public Text infomation;

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
                number = Random.Range(0, 3);

                if (number == 0) 
                {
                    infomation.text = "亂數值等於0";
                }
                if (number == 1) 
                {
                    infomation.text = "現在亂數值是一";
                }
                if (number == 2) 
                {
                    infomation.text = "亂數值是2呦";
                }
                
                
                
            }
        }
    }
}
