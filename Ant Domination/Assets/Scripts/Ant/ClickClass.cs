using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickClass : MonoBehaviour
{

    public bool test = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if ((test == false) && hit.collider != null)
            {
                Debug.Log("Target Name: " + hit.collider.gameObject.name + "\n" + "Target Position: " + hit.collider.gameObject.transform.position);
                test = true;
            }
            else if((test == true) && (hit.collider != null))
            {
                //Ant will go to this target.
                Debug.Log("Target Name 2: " + hit.collider.gameObject.name + "\n" + "Target Position 2: " + hit.collider.gameObject.transform.position);
                test = false;
            }
        }
    }
}
