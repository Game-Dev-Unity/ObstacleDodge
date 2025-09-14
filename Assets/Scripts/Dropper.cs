using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 3f;
    Rigidbody rigidbody;
    MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        rigidbody.useGravity = false;
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTime)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
