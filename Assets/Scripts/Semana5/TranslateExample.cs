using UnityEngine;

public class TranslateExample : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        
    }
    /*void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }*/
    private void Update()
    {
        //-> Metodo del translate desde 0(Crear el metodo en si)

        Vector3 dir = new Vector3(0, 0, 1);
        Vector3 globalDir = transform.rotation * dir; //-> definimos direccion local

        Vector3 movemet = globalDir * speed * Time.deltaTime; //-> definimos movimiento
        transform.position = transform.position + movemet;
    }
}
