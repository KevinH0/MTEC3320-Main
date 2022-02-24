using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        float force = 1500f;
        GameObject go = Instantiate(bullet, muzzle);
        go.GetComponent<Rigidbody>().AddForce(muzzle.forward * force);
    }
}