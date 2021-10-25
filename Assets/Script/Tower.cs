using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject _upgrade = null;
    private GameObject upgrade { get { return _upgrade; } }

    private float fireRate { get; set; } = 0.1f;
    private float currentFireRate { get; set; } = 0.0f;

    private void Start()
    {
        
    }


    private void Update()
    {
        
    }

    public void Upgrade ()
    {
        if (upgrade ==null)
        {
            return;
        }

        Instantiate(upgrade, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        other.GetComponent<>
    }
}
