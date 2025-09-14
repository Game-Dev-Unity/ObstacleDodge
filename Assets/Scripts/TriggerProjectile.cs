using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    void Start()
    {
        projectile = GameObject.FindGameObjectWithTag("Projectile");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile.SetActive(true);
        }
    }
}
