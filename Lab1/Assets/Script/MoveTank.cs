using UnityEngine;

public class MoveTank : MonoBehaviour
{
    public Rigidbody rigidbody;
    public int speedMove = 2;
    public int turnSpeedMove = 30;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rigidbody.velocity = transform.rotation * Vector3.forward * speedMove;
        }else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rigidbody.velocity = transform.rotation * -Vector3.forward * speedMove;
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeedMove, 0);
    }
}