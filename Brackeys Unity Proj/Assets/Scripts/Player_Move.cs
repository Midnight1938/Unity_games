using UnityEngine;

public class Player_Move : MonoBehaviour
{

    public Rigidbody rgBd;
    public float fwdForce = 2000f;
    public float side2side = 800;
    //! Start is called before the first frame update
    void Start()
    {
//        Debug.Log("Hello World!");
    }                               

    //! Update is called once per frame
    void FixedUpdate() // For Physics only
    {
        if (Input.GetKey(KeyCode.W))
        {
            rgBd.AddForce(0, 0, fwdForce * Time.deltaTime); //? Forward Force based on frames per sec
        }
        if (Input.GetKey(KeyCode.S))
        {
            rgBd.AddForce(0, 0, -fwdForce * Time.deltaTime); 
        }


        if (Input.GetKey(KeyCode.D))
        {
            rgBd.AddForce(side2side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rgBd.AddForce(-side2side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
