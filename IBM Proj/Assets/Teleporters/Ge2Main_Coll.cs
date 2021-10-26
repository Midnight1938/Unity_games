using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ge2Main_Coll : MonoBehaviour
{
    private void OnTriggerEnter(Collider Cold)
    {
        Cold.transform.position = new Vector3(20, Cold.transform.position.y, -7);
    }
}
