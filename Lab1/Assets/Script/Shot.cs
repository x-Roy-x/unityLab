using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject gunPoint;
    public GameObject bomb;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            var createdBomb = Instantiate(bomb, gunPoint.transform.position, gunPoint.transform.rotation);
            var bombComponent = createdBomb.GetComponent<Bomb>();
            bombComponent.gunPoint = gunPoint;    
        }
    }
}