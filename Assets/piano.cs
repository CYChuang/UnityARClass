using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class piano : MonoBehaviour
{
    GameObject key;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit)) 
            {
                text.text = text.text + "," + Hit.transform.name;

                key = GameObject.Find(Hit.transform.name);
                key.GetComponent<AudioSource>().Play();
            }
        }
    }
}
