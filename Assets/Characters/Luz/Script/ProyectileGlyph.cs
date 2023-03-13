using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileGlyph : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool hit;

    public BoxCollider2D boxcollider;
    public Animator Glyph;

    private float direction;
    private float lifetime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hit) return;
        {
            float movementSpeed = speed * Time.deltaTime * direction;
            transform.Translate(movementSpeed, 0, 0);

            lifetime += Time.deltaTime;
            if (lifetime > 5) gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        boxcollider.enabled = false;
        Glyph.SetTrigger("Hit");

        
    }

    public void SetDirection(float _direction)
    {

        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxcollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if(Mathf.Sign(localScaleX) != _direction)
        {
            localScaleX = -localScaleX;
        }

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }

    private void Deactivated()
    {
        gameObject.SetActive(false);
    }
}
