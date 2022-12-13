using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{

    // public string tag = "HEALTHPACK";
    public LayerMask tankLayer;
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
        if (other.transform == transform)
        {
            return;
        }
        else
        {   
            Debug.Log(other.gameObject);
            // other.gameObject.tankHealth.ApplyHealthChange(20);
            // TankGameEvents.OnObjectTakeDamageEvent?.Invoke(other.gameObject.transform, 20);
        }
    }

}
