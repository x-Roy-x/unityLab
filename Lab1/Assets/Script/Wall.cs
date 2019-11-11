using UnityEngine;

public class Wall: MonoBehaviour
{
    GameObject wall;

    void Start()
    {
        wall = gameObject;
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.gray;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "DestrojWall")
        {
            Destroy(wall);
        }
    }
}