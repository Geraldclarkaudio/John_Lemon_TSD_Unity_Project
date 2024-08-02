using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTrigger : MonoBehaviour
{
    [SerializeField]
    private float roomID;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(AreaAmbience.onChangeArea != null)
            {
                AreaAmbience.onChangeArea(roomID);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (AreaAmbience.onChangeArea != null)
            {
                AreaAmbience.onChangeArea(0); // sets back to halls
            }
        }
    }
}
