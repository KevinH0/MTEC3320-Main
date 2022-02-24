using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        float randomStartTime = Random.Range(0, 10f);
        float randomRepeatTime = Random.Range(2, 6);
        InvokeRepeating("MoveToRandomPosition", randomStartTime, randomRepeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(this.transform.position, newPosition, fractionOfJourney);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>())
        {
            particleSystem.Emit(100);
            this.gameObject.GetComponent<Renderer>().enabled = false;
            Destroy(this.gameObject, 2.0f);
        }
    }
    void Moveto(Transform newLocation)
    {
        startTime = Time.time;
        newPosition = new Vector3(Random.Range(-10, 10), 1.0f, Random.Range(-10, 10));
        journeyLength = Vector3.Distance(this.transform.position, newLocation.position);
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(this.transform.position, newLocation.position, fractionOfJourney);
    }
    
}
