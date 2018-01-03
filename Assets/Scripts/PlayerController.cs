using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed;
        
        private Rigidbody _rb;
        
        // Use this for initialization
        void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void FixedUpdate()
        {
            float movePlayerX = Input.GetAxis("Horizontal");
            float movePlayerY = Input.GetAxis("Vertical");
            
            Vector3 movePlayer = new Vector3(movePlayerX, 0.0f, movePlayerY);
            _rb.AddForce(movePlayer * Speed);
            
        }
    }
}