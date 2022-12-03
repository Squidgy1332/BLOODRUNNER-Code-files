using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    private Vector2 mousePosition;
    public Camera sceneCamera;
     void FixedUpdate()
    {
       Vector3 mouse = Input.mousePosition;
       Vector3 screenPoint = sceneCamera.WorldToScreenPoint(transform.localPosition);

       Vector2 offset = new Vector2 (mouse.x - screenPoint.x, mouse.y - screenPoint.y);

       float aimAngle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
       transform.rotation = Quaternion.Euler(0, 0, aimAngle);
    }
}
