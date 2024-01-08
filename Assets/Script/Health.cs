using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    public int defaultHealth;
    public int healthPoint;
    public UnityEvent OnHealthChanged;
    // Start is called before the first frame update
    void Start()
    {
        healthPoint = defaultHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(explosion, 0.7f);
    }
    public void TakeDamage(int damage)
    {
        if(healthPoint > damage)
        {
            healthPoint -= damage;
            OnHealthChanged?.Invoke();
        }
        else
        {
            Die();
        }
    }
}
