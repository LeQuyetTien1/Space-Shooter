using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Health health;
    private float originalWidth;
    void Start()
    {
        originalWidth = transform.localScale.x;
        health.OnHealthChanged.AddListener(UpdateHealthValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateHealthValue()
    {
        float scale = (float) health.healthPoint / health.defaultHealth;
        transform.localScale = new Vector3(originalWidth * scale,transform.localScale.y);
    }
}
