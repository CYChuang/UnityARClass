using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void musicon() 
    {
        this.GetComponent<AudioSource>().enabled = true;
    }

    public void musicoff()
    {
        this.GetComponent<AudioSource>().enabled = false;
    }

}
