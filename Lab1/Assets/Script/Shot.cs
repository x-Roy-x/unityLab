using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject gun_point;
    public GameObject bomb;

    void Start()
    {
        
    }

    void Update()
    { 
        if (Input.GetButtonDown("Jump"))
        {
            Transform.Instantiate(bomb, gun_point.transform.position, transform.rotation);
        }
    }
}
