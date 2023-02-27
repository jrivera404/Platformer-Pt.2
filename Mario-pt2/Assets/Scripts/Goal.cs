using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
            Debug.Log("Level Complete!");
    }
}
