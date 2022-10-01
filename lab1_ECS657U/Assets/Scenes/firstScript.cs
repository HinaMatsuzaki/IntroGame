using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public int force = 500;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        m_Rigidbody.AddForce(transform.up * force);
    }
}
