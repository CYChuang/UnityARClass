using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Musicon() 
    {
        this.GetComponent<AudioSource>().enabled = true;
    }

    public void Musicoff()
    {
        this.GetComponent<AudioSource>().enabled = false;
    }
}
