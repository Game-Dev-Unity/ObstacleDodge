using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesktopController : MonoBehaviour
{
    [SerializeField] float difficultySpeed = 2f;
    [SerializeField] float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        float xValue = 0;
        float yValue = 0;
        float zValue = 0;
        Vector3 values = SetTransformValues(xValue,yValue,zValue);
        transform.Translate(values);
    }
    Vector3 SetTransformValues(float xValue, float yValue, float zValue)
    {
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        if (SceneManager.GetActiveScene().name == "Flying")
        {
            yValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            zValue = difficultySpeed * Time.deltaTime * moveSpeed;
        }
        else if (SceneManager.GetActiveScene().name == "Grounding")
        {
            zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        }
        return new Vector3(xValue, yValue, zValue);
    }
}
