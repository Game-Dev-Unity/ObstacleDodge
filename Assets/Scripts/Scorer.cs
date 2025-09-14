using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int collisions = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            ++collisions;
            string plural = "";
            if (collisions > 1)
            {
                plural = "s";
            }
            Debug.Log($"You bumped {collisions} time{plural}");
        }
    }
}
