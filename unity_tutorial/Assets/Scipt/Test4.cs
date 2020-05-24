using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{

    private BoxCollider col;


    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //    //if(Input.GetKeyDown(KeyCode.W))
    //    //{
    //    //  //Debug.Log("col.bounds"+col.bounds);
    //    //  //Debug.Log("col.bounds.extents"+col.bounds.extents);//수정 불가
    //    //  //Debug.Log("col.bounds.extents.x" + col.bounds.extents.x);//수정 불가
    //    //  //Debug.Log("col.size" + col.size);
    //    //  //Debug.Log("col.center" + col.center);
    //    //
    //    //    
    //    //
    //    //}
    //   //if(Input.GetMouseButtonDown(0))
    //   //  {
    //   //      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //   //      RaycastHit hitinto;
    //   //      if(col.Raycast(ray,out hitinto,1000))
    //   //      {
    //   //          this.transform.position = hitinto.point;
    //   //      }
    //   //  }
    //
    //
    //
    //        
    // }
    
    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.01f);
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }
}
