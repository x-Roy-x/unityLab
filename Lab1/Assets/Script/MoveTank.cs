using UnityEngine;

public class MoveTank : MonoBehaviour
{
    public int speedMove = 10;
    public int turnSpeedMove = 100;

    void Update()
    {
        //оброка циклічна і якщо лишити  все if то їзда вперед і повороти будуть комбінуватись
        //так більш правдободіншіше на танк
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speedMove * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speedMove * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeedMove * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeedMove * Time.deltaTime);
        }
    }
}
