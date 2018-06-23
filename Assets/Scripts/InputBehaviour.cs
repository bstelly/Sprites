using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animation
{

    public class InputBehaviour : MonoBehaviour
    {

        private SpriteRenderer renderer;
        public Animator animator;

        // Use this for initialization
        void Start()
        {
            renderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                renderer.flipX = false;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += Vector3.right * 2;
                    animator.SetBool("isRunning", true);
                    animator.SetBool("isWalking", false);
                }
                else
                {
                    transform.position += Vector3.right;
                    animator.SetBool("isWalking", true);
                    animator.SetBool("isRunning", false);
                }
            }
            else
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isWalking", false);
            }

            if (Input.GetKey(KeyCode.A))
            {
                renderer.flipX = true;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += Vector3.left * 2;
                    animator.SetBool("isRunning", true);
                    animator.SetBool("isWalking", false);
                }
                else
                {
                    transform.position += Vector3.left;
                    animator.SetBool("isWalking", true);
                    animator.SetBool("isRunning", false);
                }
            }
            else
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isWalking", false);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                transform.position += Vector3.up;
                animator.SetBool("isJumping", true);
            }
        }

        void OnCollisionEnter2D()
        {
            animator.SetBool("isJumping", false);
            Debug.Log("Hit");
        }
    }
}