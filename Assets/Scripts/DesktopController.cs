using Unity.VisualScripting;
using UnityEngine;

public class DesktopController : MonoBehaviour
{
    [SerializeField] float difficultySpeed = 2f;
    [SerializeField] float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(this.GetType().Name + " initiated");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();        
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float zValue = difficultySpeed * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
