using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public string open = "OnOpen";
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D Object) 
    {
        if (Object.gameObject.tag == "Player")
        {
            animator.SetBool(open, true);
        }
    }
    private void OnTriggerExit2D(Collider2D Object)
    {
             if (Object.gameObject.tag == "Player")
        {
            animator.SetBool(open, false);
        }
    }
}
