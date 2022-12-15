using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaOfDeath : MonoBehaviour
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
        Debug.Log("Arena Entered");
        Debug.Log("Name: "+ other.gameObject.name);
        // other.gameObject.GetComponent<TankMovement>().ChangeSpeed(8);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + "Arena exited");
        TankGameEvents.OnObjectTakeDamageEvent?.Invoke(other.transform, -100);
    }

}
