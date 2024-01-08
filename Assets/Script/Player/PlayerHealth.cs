using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private GameObject overGameScene;
    // Start is called before the first frame update
    
    protected override void Die()
    {
        base.Die();
        overGameScene.SetActive(true);
    }
}
