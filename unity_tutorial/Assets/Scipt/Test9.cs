﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test9 : MonoBehaviour
{
//
//   private Animator anim;
//   private Rigidbody rigid;
//   private BoxCollider col;
//
//   [SerializeField] private float moveSpeed;
//   [SerializeField] private float jumpForce;
//   [SerializeField] private LayerMask layerMask;
//
//   private bool isMove;
//   private bool isJump;
//   private bool isFall;
//   // Start is called before the first frame update
  void Start()
   {
//       anim = GetComponent<Animator>();
//       rigid = GetComponent<Rigidbody>();
//       col = GetComponent<BoxCollider>();
   }
//
//   // Update is called once per frame
//   void Update()
//   {
//       TryWalk();
//       TryJump();
//   }
//   private void TryJump()
//   {
//       if (isJump)
//       {
//           if (rigid.velocity.y >= -0.1f && !isFall)
//               {
//                   isFall = true;
//                   anim.SetTrigger("Fall");
//               }
//           RaycastHit hitInfo;
//           if (Physics.Raycast(transform.position, -transform.up, out hitInfo, col.bounds.extents.y+0.1f, layerMask))
//           {
//               anim.SetTrigger("Land");
//               isJump = false;
//               isFall = false;
//           }
//       }
//       if(Input.GetKeyDown(KeyCode.Space)&&!isJump)
//       {
//           isJump = true;
//           rigid.AddForce(Vector3.up * jumpForce);
//           anim.SetTrigger("Jump");
//       }
//   }
//
//
//   private void TryWalk()
//   {
//       float _dirX = Input.GetAxisRaw("Horizontal");
//       float _dirZ = Input.GetAxisRaw("Vertical");
//       isMove = false;
//       Vector3 direction = new Vector3(_dirX, 0, _dirZ);
//
//       if (direction != Vector3.zero)
//       {
//           isMove = true;
//           this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);//총합을 1로 만들기위해 
//
//       }
//       anim.SetBool("Move", isMove);
//       anim.SetFloat("DirX", direction.x);
//       anim.SetFloat("DirZ", direction.z);
 }

