using UnityEngine;

public class Crate : MonoBehaviour
{
    Renderer rend;
    readonly Color[] colors = { 
        Color.red, Color.blue, Color.green, Color.cyan, 
        Color.grey, Color.magenta, Color.yellow
    };

    void Start()
    {
        rend = GetComponent<Renderer>();
        int randomIndex = Random.Range(0, colors.Length);
        rend.material.color = colors[randomIndex];
    }

    void Update()
    {
        
    }
}
