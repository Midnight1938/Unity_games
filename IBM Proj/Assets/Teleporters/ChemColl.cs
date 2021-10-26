using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemColl : MonoBehaviour
{
    private void OnTriggerEnter(Collider Cold)
    {
        Cold.transform.position = new Vector3(-4, Cold.transform.position.y, 17);
    }
}
