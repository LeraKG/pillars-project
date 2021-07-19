using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCapsule : MoveRight
{

    private Rigidbody rB;

    private float moveSpeedCaps = 3;



    //private values encaps

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

    // poly override below
    public override void MoveR()
    {
        rB.AddRelativeForce(Vector3.right * moveSpeedCaps);
    }
    public override void LookAtTarget()
    {
        transform.LookAt(new Vector3(0, 0.34f, 0));
        transform.Rotate(90, 0, 0);
    }

}
