using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    
    private Transform m_Target;
    public Transform Target
    {
        get { return m_Target; }
        set { m_Target = transform; }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_Target = GameObject.Find("LookAtThis").transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveR();
        LookAtTarget();
    }

    public virtual void MoveR()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 5); 
    }
    public virtual void LookAtTarget()
    {
        transform.LookAt(m_Target);
    }
}
