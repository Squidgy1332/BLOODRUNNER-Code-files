using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootAn : MonoBehaviour
{
    private Animator Manimation;
    
    private float moveH;
    
    private float moveV;

    private void Start() 
    {
        Manimation = GetComponent<Animator>();
    }
    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (moveV != 0f || moveH != 0f)
        {
            Manimation.SetTrigger("move");
        }

        else
        {
            Manimation.SetTrigger("stop");
        }
    }
}
