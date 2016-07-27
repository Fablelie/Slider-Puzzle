using UnityEngine;
using System.Collections;

/// <summary>
/// Make sure to base(Number) object can move.
/// </summary>
public class CanMove : MonoBehaviour
{
    public bool can = false;
    public GameObject obj;

    private Renderer ran;

    void Start ()
    {
        ran = gameObject.GetComponent<Renderer>();
    }

    void OnTriggerStay(Collider other)
    {   
        if (other.transform.gameObject.tag == "Spac")
        {
            can = true;
            obj = other.gameObject;
        }

        // Change color if object stry on position.
        if ( other.transform.gameObject.tag == "BG" && "Obj_" + other.gameObject.name == gameObject.name )
        {
            ran.material.color = Color.green;
        }
    }

    void OnTriggerExit ( Collider other )
    {
        if (other.transform.gameObject.tag == "Spac")
        {
            can = false;
            obj = null;
        }

        if (other.transform.gameObject.tag == "BG")
        {
            ran.material.color = Color.white;
        }
    }

}
