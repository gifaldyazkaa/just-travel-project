using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController2D controller2D;
    float horizontal;
    bool jump;
    [Header("Variables")]
    public float runSpeed;
    public Animator animator;
    [Space]
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        controller2D = this.GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            horizontal = Input.GetAxis("Horizontal") * runSpeed;

            if(Input.GetMouseButtonDown(0))
            {
                canMove = false;
                animator.SetTrigger("attack");
            }
        }

        else
        {
            horizontal = 0;
        }

        if (Input.GetButtonDown("Jump") && canMove)
        {
            jump = true;
            canMove = false;
            animator.SetBool("isJump", true);
        }

        if (horizontal != 0 && canMove)
            animator.SetBool("isRun", true);
        else animator.SetBool("isRun", false);
    }

    private void FixedUpdate()
    {
        controller2D.Move(horizontal * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void Landing()
    {
        canMove = true;
        animator.SetBool("isJump", false);
    }
}
