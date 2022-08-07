using System;
using UnityEditor;
using UnityEngine;

namespace PlayerBase
{
    public class PlayerMove : MonoBehaviour
    {
        public Rigidbody Rigidbody;
        public float MoveSpeed;
        public float ForceJump;
        
        public bool IsGrounded;
        
        private bool _isJump;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded) 
                _isJump = true;
        }

        private void FixedUpdate()
        {
            Rigidbody.AddForce(Input.GetAxis("Horizontal") * MoveSpeed, 0, 0, ForceMode.VelocityChange);

            if (_isJump)
            {
                Rigidbody.AddForce(0, ForceJump, 0, ForceMode.VelocityChange);
                _isJump = false;
            }
        }

        private void OnCollisionStay(Collision other) => 
            IsGrounded = true;

        private void OnCollisionExit(Collision other) => 
            IsGrounded = false;
    }
}