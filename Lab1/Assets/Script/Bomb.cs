using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject bomb;
    public int shotSpeedMove = 150;

    void Start()
    {
        
    }

    void Update() 
    {
        transform.Translate(Vector3.forward * shotSpeedMove * Time.deltaTime);
        if(transform.position.y < 1) 
        {
            Destroy(bomb);
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Destroyable") {
            Destroy(bomb);
        }
    }
}
