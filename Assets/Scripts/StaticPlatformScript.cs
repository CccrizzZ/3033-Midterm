using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPlatformScript : MonoBehaviour
{

    public Material unlit;
    public Material lit;



    public void ResetColor()
    {
        GetComponent<Renderer>().material = unlit;
    }

    void OnCollisionEnter(Collision other)
    {
        // Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Player") && other.transform.position.y > transform.position.y)
        {
            GetComponent<Renderer>().material = lit;
        }
    }
}
