using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float timeShoot;
    private float time = 0;
    [SerializeField] private Vector3 bulletOffset;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (time < timeShoot)
            {
                time += Time.deltaTime;
            }
            else
            {
                Instantiate(bullet, transform.position+ bulletOffset, transform.rotation);
                time = 0;
            }
        }      
    }
}
