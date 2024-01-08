using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float flySpeed;
    public int bulletDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime* flySpeed;
        if(transform.position.y>7) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if(enemy != null)
        {
            enemy.TakeDamage(bulletDamage);
        }
        
        Destroy(gameObject);
    }
}
