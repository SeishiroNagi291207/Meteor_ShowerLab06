using UnityEngine;

public class Exercise01_MRU : MonoBehaviour
{
    public float speed = 8f;
    private float objetivoX = 40f;
    void Start()
    {
        
    }
    void Update()
    {
        if (transform.position.x < objetivoX)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
