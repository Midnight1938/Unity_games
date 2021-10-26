using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider Cold)
    {
        Cold.transform.position = new Vector3 (-5, Cold.transform.position.y, -7);
    }
}
