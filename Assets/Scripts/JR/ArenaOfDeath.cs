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
        Debug.Log(other.gameObject.name + "entered arena.");
    }

    private void OnTriggerExit(Collider other)
    {
        TankGameEvents.OnObjectTakeDamageEvent?.Invoke(other.transform, -100);
    }

}
