using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcon : MonoBehaviour
{
    public AudioClip[] Clips;
    public AudioSource myAudioSource;
    string btnName;
    
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            
        if(Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit)) 
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "A":
                        myAudioSource.clip = Clips[0];
                        myAudioSource.Play();
                        break;
                    case "B":
                        myAudioSource.clip = Clips[1];
                        myAudioSource.Play();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
