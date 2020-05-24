using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    //Vector3 rotation;
    //void Start()
    //{
    //    rotation = this.transform.eulerAngles;
    //}

    // Update is called once per frame

    [SerializeField]
    private GameObject go_camera;

    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    // this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;//60분의 1
        //    // this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); //위에와 같지만 다른 방법
        //    // this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;// 오류가 생기는 코드
        //    //this.transform.eulerAngles = rotation; // 상황에 따라서 다르게함
        //    //Debug.Log(transform.eulerAngles);
        //    //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
        //    //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;//회전
        //    //this.transform.rotation = Quaternion.Euler(rotation);//짐벌락 현상생길것같을때 사용
        //    //moveSeed * this.transform.forward * Time.deltaTime //정규화 벡터 (방향만을 알려주는 녀석) new Vector3(0,0,1)
        //    this.transform.LookAt(go_camera.transform.position); //카메라가 나를 바라보게 한다.
        //
        //} 
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);

    }
}
