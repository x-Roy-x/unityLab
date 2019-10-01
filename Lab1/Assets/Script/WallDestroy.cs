using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    public GameObject wall;

    Vector3 posirionStart;
    Vector3 posirionUpdate;

    void Start()
    {
        posirionStart = transform.position;
    }

    void Update()
    {
        posirionUpdate = transform.position;
        //реалізація дивна і ніхто так не робить але так цікавіше працює
        //любий обєкт може збити стіну
        if(posirionUpdate != posirionStart)
        {
            //GetComponent<Rigidbody>().AddForce(transform.forward * 50);
            Destroy(wall);
        }
    }

    /*
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "WallDestroy")
        {
            Destroy(col.gameObject);
        }
    }
    */
}
