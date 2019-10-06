using UnityEngine;

public class Wall: MonoBehaviour
{
    GameObject wall;

    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        wall = gameObject;

        rend.material.color = Color.gray;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(wall);
        }
        
    }
}
