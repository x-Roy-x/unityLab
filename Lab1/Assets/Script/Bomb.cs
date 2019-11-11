using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject bomb;
    public GameObject gunPoint;
    public int shotSpeedMove = 150;
    public Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = gunPoint.transform.rotation * Vector3.forward * shotSpeedMove ;
    }
    
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "DestrojBomb") {
           Destroy(bomb);
        }
    }
}