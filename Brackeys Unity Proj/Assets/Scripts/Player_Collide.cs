using UnityEngine;

public class Player_Collide : MonoBehaviour
{
    public Player_Move Mover;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We Hit");
            Mover.enabled = false;
        }
        
    }
}
