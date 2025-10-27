using UnityEngine;

public class ThrowGranede : MonoBehaviour
{
    public float throwForce = 500;
    public GameObject grenadePrefab; 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.timeScale != 0) 
        {
            Throw ();
        }
    }
    public void Throw()
    {
        GameObject newGrenade = Instantiate(grenadePrefab, transform.position,transform.rotation);

        newGrenade.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);

    }
}
