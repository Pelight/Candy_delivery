using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float delay = 0.5f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {   
            hasPackage = true;
            Debug.Log("Picked up icecream");
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }
        if (collision.CompareTag("Monsters") && hasPackage){
            Debug.Log("Delivered a package");
            GetComponent<ParticleSystem>().Stop();
            hasPackage = false;
            Destroy(collision.gameObject, delay);
        }
    }
}
