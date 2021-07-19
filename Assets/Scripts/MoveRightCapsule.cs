using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCapsule : MoveRight
{

    private Rigidbody rB;

    private float m_moveSpeedCaps = 3;
    public float MoveSpeed
    {
        get { return m_moveSpeedCaps; }
        set { MoveSpeed = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
       rB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveR();
        LookAtTarget();
    }
    public override void MoveR()
    {
        rB.AddRelativeForce(Vector3.right * m_moveSpeedCaps);
    }
    public override void LookAtTarget()
    {
        base.LookAtTarget();
        transform.Rotate(90, 0, 0);
    }

}
