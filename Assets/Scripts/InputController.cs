using UnityEngine;
using System.Collections;

/// <summary>
/// Input controller for controller player input.
/// </summary>
public class InputController : MonoBehaviour
{
    /// <summary>
    /// Spac when player click on near object it will switch position.
    /// </summary>
    public GameObject objNull;

    /// <summary>
    /// timeCount when player click on the object.
    /// </summary>
    public int timeCount;
	
	void Update ()
    {
	    if ( Input.GetMouseButtonDown(0) )
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if ( Physics.Raycast( ray, out hit, 100.0f ) )
            {

                // check base object on click if it can move.
                if (hit.collider.transform.tag == "Number" && hit.collider.gameObject.GetComponent<CanMove>().can)
                {
                    Vector3 vec = hit.transform.position;
                    hit.transform.position = objNull.transform.position;
                    objNull.transform.position = vec;

                    timeCount++;
                }
            }
        }
	}
}
