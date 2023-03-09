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
    private InstantianteGlyphs InstantianteGlyphsScript;
    private TrigguerDialogue TrigguerDialogueScript;

    public GameObject[] thrownGlyph;
    public GameObject GlypsBagOn;
    public GameObject FirePoint;

    public int SelectedGlyph = 0;

    void Start()
    {
        InstantianteGlyphsScript = FindObjectOfType<InstantianteGlyphs>();
        TrigguerDialogueScript = FindObjectOfType<TrigguerDialogue>();
        Time.timeScale = 1;
        isCroutching = false;
        SelectGlyph();

    }

    // Update is called once per frame
    void Update()
    {

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


        int previousSelectedGlyph = SelectedGlyph;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SelectedGlyph <= 0)
                SelectedGlyph = transform.childCount - 1;
            else
                SelectedGlyph--;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {

            if (SelectedGlyph >= transform.childCount - 1)
                SelectedGlyph = 0;
            else
                SelectedGlyph++;
        }

        if (previousSelectedGlyph != SelectedGlyph)
        {
            SelectGlyph();
        }

        Flip();

        if (Input.GetButtonDown("Fire1"))
        {
            
            ShootGlyph();
            Attack();
            
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
       
        Luz.SetBool("IsAttacking", true);
        Debug.Log("Attack");
    }

    public void NonAttack()
    {
        
        Luz.SetBool("IsAttacking", false);
        
    }

    public void SelectGlyph()
    {
        int i = 0;
        foreach (Transform glyph in transform)
        {
            if (i == SelectedGlyph)

                glyph.gameObject.SetActive(true);

            else

                glyph.gameObject.SetActive(false);

            i++;
        }
    }

    void ShootGlyph()
    {
        if (GlypsBagOn.activeInHierarchy)
        {
            Instantiate(thrownGlyph[SelectedGlyph], FirePoint.transform.position,
                        FirePoint.transform.rotation);
        }

    }
}
