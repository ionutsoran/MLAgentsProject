using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCity : MonoBehaviour
{
    public float width;
    public float height;
    int[] const_triangles;
    public List<Vector3> vertices;
    public List<int> triangles;
    public List<Vector3> normals;
    public int Size;


    void Start()
    {
        Size = 3;
        gameObject.AddComponent<MeshRenderer>();
        gameObject.AddComponent<MeshFilter>();
        const_triangles = new int[] { 0, 4, 1, 0, 1, 2, 1, 2, 3, 1, 3, 4 };
        vertices = new List<Vector3>();
        triangles = new List<int>();

        for (int i = 0; i < 2 * Size + 1; i++)
            for (int j = 0; j < 2 * Size + 1; j++)
                AddToVertices(i, j);

        Mesh mesh = new Mesh();
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();

        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;

    }

    public void AddToVertices(int i, int j)
    {
        Vector3[] temp_vertices = new Vector3[5];

        int last_icount = vertices.Count;

        //if(i%2==0 && j%2==0)// to be implemented
        {
            //temp_vertices[0] = new Vector3(j * width / 2, 0f, i * height / 2);
            //temp_vertices[1] = new Vector3((j - 1) * width, 0f, (i - 1) * height);
            //temp_vertices[2] = new Vector3((j - 1) * width, 0f, height);
            //temp_vertices[3] = new Vector3(width, 0f, height);
            //temp_vertices[4] = new Vector3(width, 0f, (i - 1) * height);
        }
        //else
        {
            temp_vertices[0] = new Vector3(j * width / 2, 0f, i * height / 2);
            temp_vertices[1] = new Vector3((j - 1) * width, 0f, (i - 1) * height);
            temp_vertices[2] = new Vector3((j - 1) * width, 0f, height);
            temp_vertices[3] = new Vector3(width, 0f, height);
            temp_vertices[4] = new Vector3(width, 0f, (i - 1) * height);
            for (int k = 0; k < temp_vertices.Length; k++)
            {
                vertices.Add(temp_vertices[k]);
                normals.Add(-Vector3.forward);
            }

            for (int k = 0; k < const_triangles.Length; k++)
                triangles.Add(last_icount + const_triangles[k]);
        }
        

       
    }
}
