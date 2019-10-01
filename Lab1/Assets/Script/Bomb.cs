
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject bomb;
    public int shotSpeedMove = 100;

    void Update()
    {
        transform.Translate(Vector3.forward * shotSpeedMove * Time.deltaTime);
        if(transform.position.y < 0.1)
        {
            Destroy(bomb);
        }
    }
}
