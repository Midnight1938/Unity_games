using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider Cold)
    {
        Cold.transform.position = new Vector3(3, Cold.transform.position.y, 15);
    }
}
