using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
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
        transform.LookAt(target);
    }
}
