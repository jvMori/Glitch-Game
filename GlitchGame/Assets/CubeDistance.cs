using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeDistance : MonoBehaviour {

    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;
    private float distance;

   

    private void Start()
    {
        startPos = gameObject.transform.position;
    }
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseUp()
    {
        gameObject.transform.DOMove(startPos, .5f);
        distance = 0;
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;

        distance += Vector3.Distance(startPos, transform.position);
      
    }

   
}
