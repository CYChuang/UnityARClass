using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class twobuttonclick : MonoBehaviour
{
    public Button button1, button2;
    public GameObject bee1, bee2;
    public Text infomation;
    public RawImage image1, image2;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(delegate { btn1click(); });
        button2.onClick.AddListener(delegate { btn2click(); });
        
    }
    private void btn1click()
    {
        bee1.gameObject.SetActive(true);
        infomation.text = "這是第一隻蜜蜂";
        image1.gameObject.SetActive(true);
        bee2.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);

    }
    private void btn2click()
    {
             
        bee2.gameObject.SetActive(true);
        infomation.text = "第二隻蜜蜂是我";
        image2.gameObject.SetActive(true);
        bee1.gameObject.SetActive(false);
        image1.gameObject.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
