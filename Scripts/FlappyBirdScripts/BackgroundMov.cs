using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMov : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            transform.localPosition = new Vector3(transform.localPosition.x + GetComponent<BoxCollider2D>().bounds.size.x*2, transform.localPosition.y,transform.localPosition.z);
            
        }
    }
}
