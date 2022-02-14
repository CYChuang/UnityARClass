using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchBeeMove : MonoBehaviour
{
    public GameObject model;
    public Text Debugtext;

    public Touch Touchpoint1, Touchpoint2, NewTouchpoint1, NewTouchpoint2;
    // Start is called before the first frame update
    void Start()
    {
        Input.multiTouchEnabled = true;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1) 
        {
            //Touch touch1 = Input.touches[0];
            Debugtext.text = model.transform.position.x.ToString() + "，"+
                             model.transform.position.y + "，" +
                             Input.touches[0].deltaPosition.x + "，" +
                             Input.touches[0].deltaPosition.y;


            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform.name == model.name && Input.touches[0].phase == TouchPhase.Moved
                )
                //被射線打到的東西的名稱 == 遊戲物件model的名稱
            {
                model.transform.Translate(new Vector3
                    (Input.touches[0].deltaPosition.x * 30 * Time.deltaTime,
                    Input.touches[0].deltaPosition.y * 30 * Time.deltaTime, 0));


            }
        }

        NewTouchpoint1 = Input.GetTouch(0);
        NewTouchpoint2 = Input.GetTouch(1);

        if (NewTouchpoint2.phase == TouchPhase.Began) 
        {
            Touchpoint1 = NewTouchpoint1;
            Touchpoint2 = NewTouchpoint2;
        }

        float distance = Vector2.Distance
            (Touchpoint1.position, Touchpoint2.position);
        float Newdistance = Vector2.Distance
            (NewTouchpoint1.position, NewTouchpoint2.position);
        float offset = Newdistance - distance;

        Vector3 oldscale = model.transform.localScale;

        Vector3 scale = new Vector3(oldscale.x+ offset, oldscale.y+ offset, oldscale.z+ offset);

        if (scale.x > 20 && scale.y >20 && scale.z >20) 
        { 
            model.transform.localScale = scale;
        }

        Touchpoint1 = NewTouchpoint1;
        Touchpoint2 = NewTouchpoint2;
    }
}
