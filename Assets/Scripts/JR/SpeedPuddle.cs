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
        other.gameObject.GetComponent<Tank>().tankMovement.ApplySpeedBuff(true);
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Tank>().tankMovement.ApplySpeedBuff(false);
    }

}
