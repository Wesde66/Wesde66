using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Vector2 AttackPoint;
    public Transform attackPoint;
    public LayerMask Mask;
    public int Damage;
    public Animator anim;
    
    public float Radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackPoint = attackPoint.position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackEnemy();
        }

        
    }

    void attackEnemy()
    {
            Debug.Log("Hit");
            anim.SetTrigger("Attack");
        
    }

    void DetectEnemy()
    {
       Collider2D col =  Physics2D.OverlapCircle(AttackPoint, Radius, Mask);
        if(col != null)
        {
            if(col.tag == "Pig")
            {
                col.GetComponent<PigHealth>().TakeDamage(Damage);
            }
        }

       
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPoint.position, Radius);
    }
}
