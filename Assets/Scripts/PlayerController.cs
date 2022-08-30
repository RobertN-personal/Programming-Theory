using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 worldPosition;
    Plane plane = new Plane(Vector3.up, 0);
    

    void Update()
    {
        CalculateMousePosition();
    }

    

    private void OnMouseDrag() 
    {
        transform.position = worldPosition;
    }

    //ABSTRACTION
    private void CalculateMousePosition()
    {
        float distance;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        }
    }
}
