using UnityEngine;

public class MatrixGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public int width = 5;
    public int height = 5;
    public float spacing = 2f;
    void Start()
    {
        GenerateMatrix();
    }
    void GenerateMatrix ()
    {
        for (int x = 0; x < width; x++)
        {
            for(int z = 0;  z < height; z++)
            {
                Vector3 position = new Vector3(x * spacing, 0, z * spacing);
                position.y = Mathf.Cos(x * 0.5f) + Mathf.Cos(z * 0.5f);
                GameObject newCube = Instantiate(cubePrefab, position, Quaternion.identity);

                float ColorR = (float)x / width;
                float ColorG = (float)z / height;

                newCube.GetComponent<Renderer>().material.color = new Color(ColorR, ColorG, 0);
            }
        }
    }
}
