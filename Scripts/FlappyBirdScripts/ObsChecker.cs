using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsChecker : MonoBehaviour
{

    [SerializeField]
    float xDistance;

    [SerializeField]
    float minHeight;

    [SerializeField]
    float maxHeight;

    [SerializeField]
    GameObject coin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacles"))
        {

            collision.gameObject.transform.localPosition = new Vector3(collision.gameObject.transform.localPosition.x+xDistance,Random.Range(minHeight, maxHeight),0f);
            Instantiate(coin, collision.gameObject.transform);
        }
    }
}
