using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPuddle : MonoBehaviour
{
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {      
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Speedpuddle Entered");
        Debug.Log("Name: "+ other.gameObject.name);
        // other.gameObject.GetComponent<TankMovement>().ChangeSpeed(8);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + "Speedpuddle exited");
        // collision.gameObject.tankMovement.ChangeSpeed(-8);
    }

}
