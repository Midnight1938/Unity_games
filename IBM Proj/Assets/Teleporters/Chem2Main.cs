using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chem2Main : MonoBehaviour
{
    private void OnTriggerEnter(Collider Cold)
    {
        Cold.transform.position = new Vector3(20, Cold.transform.position.y, -7);
    }
}
