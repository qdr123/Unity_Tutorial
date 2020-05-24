using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{

    private Rigidbody myRigid;
   // private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
       // rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            // myRigid.velocity = Vector3.forward;//= new Vector3(0, 0, 1);
            // myRigid.angularVelocity = Vector3.right; // -Vector3.right(왼쪽) //Vector3.right()오른쪽 //= new Vector3(1,0,0);
            // myRigid.maxAngularVelocity = 1000; 속도 조절
            // myRigid.angularVelocity = Vector3.right * 100;
            //myRigid.MovePosition(transform.forward); //앞으로 이동 점멸처럼
            // rotation += new Vector3(90, 0, 0) * Time.deltaTime;//누르고있을때 회전 하게함
            //myRigid.MoveRotation(Quaternion.Euler(rotation));//강제로 이동
            //myRigid.AddForce(Vector3.forward);//관성이 적용됨 질량도 같이 적용됨 천천히 감속
            //myRigid.AddTorque(Vector3.up);//회전에서 관성 적용
            myRigid.AddExplosionForce(10, this.transform.right, 10);//폭발 움직이게 한다.// add 시리즈는 모두 물리효과와 관련있다.
        }
    }
}
