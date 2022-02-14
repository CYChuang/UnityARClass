using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchMove : MonoBehaviour
{
    public GameObject model;

    Touch Touchpoint1;
    Touch Touchpoint2;

    public Text text;
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
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
            
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                text.text =   model.name ;

                if (Physics.Raycast(ray, out Hit)) 
                { 
                    text.text = Hit.transform.name + "+" + model.name;
                }
                
            }

            if (Input.touches[0].phase == TouchPhase.Moved) 
            {
                if (Physics.Raycast(ray, out Hit) && Hit.transform.name == model.name)
                {
                    model.transform.Translate(new Vector3(Input.touches[0].deltaPosition.x * 30 * Time.deltaTime, Input.touches[0].deltaPosition.y * 30 * Time.deltaTime, 0));
                }
            }
        }
        

        Touch newTouchPoint1 = Input.GetTouch(0);
        Touch newTouchPoint2 = Input.GetTouch(1);

        if (newTouchPoint2.phase == TouchPhase.Began) 
        {
            Touchpoint1 = newTouchPoint1;
            Touchpoint2 = newTouchPoint2;
        }

        float distance = Vector2.Distance(Touchpoint1.position, Touchpoint2.position);
        float newdistance = Vector2.Distance(newTouchPoint1.position, newTouchPoint2.position);
        float offset = newdistance - distance;
        

        Vector3 localscale = model.transform.localScale;
        Vector3 scale = new Vector3(localscale.x + offset,localscale.y+ offset,localscale.z+ offset);

        if (scale.x > 20 && scale.y >20 && scale.z >20) 
        {
            model.transform.localScale = scale;
        }

        Touchpoint1 = newTouchPoint1;
        Touchpoint2 = newTouchPoint2;
    }
}
