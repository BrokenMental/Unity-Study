using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceCtrl : MonoBehaviour {

    public Transform target;
    public float rotSpeed = 90.0f;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        moveSpeed = Random.Range(100, 500);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.target != null)
        {
            this.RotateToTarget();
        }
    }

    void RotateToTarget()
    {
        float deltaRot = this.rotSpeed * Time.deltaTime;

        Vector3 dirToTarget = this.target.position - this.transform.position;
        dirToTarget.Normalize();
        Quaternion q = Quaternion.LookRotation(dirToTarget);
        Quaternion s = Quaternion.Slerp(transform.rotation, q, rotSpeed * Time.deltaTime);
        transform.rotation = s;

        float distAngle = Mathf.Acos(Vector3.Dot(dirToTarget, this.transform.forward)) * Mathf.Rad2Deg;

        transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime);

        if (distAngle > 0.1f)
        {
            float t = Mathf.InverseLerp(0, distAngle, deltaRot);

        }
    }
}
