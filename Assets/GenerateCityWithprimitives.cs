using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCityWithprimitives : MonoBehaviour
{
    public int Size;
    public float scalarX;
    public float scalarY;
    public float scalarZ;
    public GameObject[,] objMatrix;
    public GameObject wall_N, wall_S, wall_E, wall_W;
    public Material brick;

    void Start()
    {
        objMatrix = new GameObject[2 * Size + 1, 2 * Size + 1];
        for (int i = 0; i < objMatrix.GetLength(0); i++)
            for (int j = 0; j < objMatrix.GetLength(1); j++)
            {
                /*if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
                {
                    float y = Random.Range(scalarY / 3, scalarY);
                    objMatrix[i, j] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    objMatrix[i, j].transform.localScale = new Vector3(scalarX, y, scalarZ);
                    objMatrix[i, j].transform.position = new Vector3(j * scalarX, y / 2, i * scalarZ);
                }
                else*/
                {
                    objMatrix[i, j] = GameObject.CreatePrimitive(PrimitiveType.Quad);
                    objMatrix[i, j].transform.localScale = new Vector3(scalarX, scalarZ, 1);
                    objMatrix[i, j].transform.rotation = Quaternion.Euler(90, 0, 0);
                    objMatrix[i, j].transform.position = new Vector3(j * scalarX, -0.5f, i * scalarZ);
                    objMatrix[i, j].GetComponent<MeshCollider>().convex = true;
                }

                objMatrix[i, j].transform.parent = transform;
                //objMatrix[i, j].AddComponent<MeshCollider>();
            }

        wall_W = GameObject.CreatePrimitive(PrimitiveType.Quad);
        wall_W.transform.localScale = new Vector3(objMatrix.GetLength(0) * scalarX, scalarZ, 1);
        wall_W.transform.position = new Vector3(-scalarX / 2, scalarZ/2, (objMatrix.GetLength(0) - 1) * scalarZ / 2);
        wall_W.transform.rotation = Quaternion.Euler(0, -90, 0);
        wall_W.GetComponent<MeshCollider>().convex = true;
        wall_W.GetComponent<MeshRenderer>().material = brick;
        wall_W.transform.parent = transform;

        wall_E = GameObject.CreatePrimitive(PrimitiveType.Quad);
        wall_E.transform.localScale = new Vector3(objMatrix.GetLength(0) * scalarX, scalarZ, 1);
        wall_E.transform.position = new Vector3(objMatrix.GetLength(0) * scalarX- scalarX/2, scalarZ/2, (objMatrix.GetLength(0) - 1) * scalarZ / 2);
        wall_E.transform.rotation = Quaternion.Euler(0, 90, 0);
        wall_E.GetComponent<MeshCollider>().convex = true;
        wall_E.GetComponent<MeshRenderer>().material = brick;
        wall_E.transform.parent = transform;

        wall_N = GameObject.CreatePrimitive(PrimitiveType.Quad);
        wall_N.transform.localScale = new Vector3(objMatrix.GetLength(0) * scalarX, scalarZ, 1);
        wall_N.transform.position = new Vector3((objMatrix.GetLength(0)-1) * scalarX/2, scalarZ/2, objMatrix.GetLength(0) * scalarZ- scalarZ/2);
        wall_N.transform.rotation = Quaternion.Euler(0, 0, 0);
        wall_N.GetComponent<MeshCollider>().convex = true;
        wall_N.GetComponent<MeshRenderer>().material = brick;
        wall_N.transform.parent = transform;

        wall_S = GameObject.CreatePrimitive(PrimitiveType.Quad);
        wall_S.transform.localScale = new Vector3(objMatrix.GetLength(0) * scalarX, scalarZ, 1);
        wall_S.transform.position = new Vector3((objMatrix.GetLength(0) - 1) * scalarX / 2, scalarZ/2, -scalarZ/2);
        wall_S.transform.rotation = Quaternion.Euler(0, 180, 0);
        wall_S.GetComponent<MeshCollider>().convex = true;
        wall_S.GetComponent<MeshRenderer>().material = brick;
        wall_S.transform.parent = transform;

    }
}
