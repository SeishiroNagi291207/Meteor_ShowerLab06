using UnityEngine;

public class ScaleExample : MonoBehaviour
{
    //Unity scale
    //public float scaleFactor = 2f;

    //Manual scale
    //public Vector3 scaleFactor = new Vector3(2f, 0.5f, 1f);

    //Pulse scale
    public float amplitude = 0.5f;
    public float frequency = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //1st way Unity scale
        //transform.localScale = new Vector3 ( scaleFactor , scaleFactor,scaleFactor);
        
        //2nd way scale(Manual scale)
        //Matrix4x4 localMatrix = Matrix4x4.identity;
        //localMatrix[0,0] = scaleFactor.x;
        //localMatrix[1,1] = scaleFactor.y;
        //localMatrix[2,2] = scaleFactor.z;

        //transform.localScale = localMatrix.lossyScale;
        
        //3rd way scale (Pulse)
        float mult = 1+Mathf.Sin(Time.time * frequency) * amplitude;
        transform.localScale = Vector3.one * mult;
    }
}
