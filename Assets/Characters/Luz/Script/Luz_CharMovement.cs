using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz_CharMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 7f;
    private float JumpingPower = 20f;
    private bool isFacingRight = true;
    private bool isJumping = false;
    private bool isCroutching = false;

   

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask groundLayer;

    public Animator Luz;

    [SerializeField] private float AttackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] GlyphsToss;
    private float cooldownTimer = Mathf.Infinity;


  

 


    void Start()
    {
  
        Time.timeScale = 1;
        isCroutching = false;
        

    }

    // Update is called once per frame
    void Update()
    {

        if (dialogueManager.isActive == true)
        {
            return;
        }

        if (IsGrounded())
        {
            isJumping = false;
            Luz.SetBool("IsJumping", false);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        Luz.SetFloat("Speed", Mathf.Abs(horizontal));



        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
            isJumping = true;
            Luz.SetBool("IsJumping", true);
        }




        Luz.SetBool("IsJumping", !IsGrounded());

        if (Input.GetButtonDown("Vertical"))
        {
            Luz.SetBool("IsCroutching", true);
        }
        else
        {
            Luz.SetBool("IsCroutching", false);
        }



        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);

        }

       


        Flip();

        if (Input.GetButtonDown("Fire1") && cooldownTimer > AttackCooldown)
        {
            
         
            Attack();
            cooldownTimer += Time.deltaTime;
            
        }
        else
        {
            NonAttack();
            
        }



    }
    

   
    private void FixedUpdate ()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.1f, groundLayer);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    public void Attack()
    {

        cooldownTimer = 0;
       
        Luz.SetBool("IsAttacking", true);
        Debug.Log("Attack");

        GlyphsToss[FindGlyph()].transform.position = firePoint.position;
        GlyphsToss[FindGlyph()].GetComponent<ProyectileGlyph>().SetDirection(Mathf.Sign(transform.localScale.x));
    }

    public void NonAttack()
    {
        
        Luz.SetBool("IsAttacking", false);
        
    }

    private int FindGlyph()
    {
        for (int i= 0; i < GlyphsToss.Length; i++)
        {
            if(!GlyphsToss[i].activeInHierarchy)
            {
                return i;
            }
        }

        return 0;
    }
  
    


}
