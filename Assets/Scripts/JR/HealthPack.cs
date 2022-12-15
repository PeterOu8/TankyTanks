using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
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

    private void OnCollisionEnter(Collision other)
    {
            TankGameEvents.OnObjectTakeDamageEvent?.Invoke(other.gameObject.transform, 20);
            Destroy(this.gameObject);
    }

}
