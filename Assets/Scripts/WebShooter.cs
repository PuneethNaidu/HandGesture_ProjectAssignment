using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject webPrefab;
    [SerializeField]
    private Transform shootPoint;
    [SerializeField]
    private float shootForce = 15f;
    [SerializeField]
    private AudioSource audiSource;
    [SerializeField]
    private AudioClip shootClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void OnWebShoot()
    {
        GameObject newWeb = Instantiate(webPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody rb = newWeb.GetComponent<Rigidbody>();
        if(rb)
        {
            //physics to move the web ball
            rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
            //play audio when you shoot the web
            audiSource.PlayOneShot(shootClip);
        }
    }
}
