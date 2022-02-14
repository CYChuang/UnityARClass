using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMove0729 : MonoBehaviour
{
    public GameObject model;
    bool isDie;
    string btnName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        //按下滑鼠左鍵
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) 
            {
                btnName = hit.transform.name;

                if (btnName == "A") 
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
            }
        }
    }
}
