using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class ChopterAcademy : Academy
{
    public GameObject[] agents;
    public  static float min_ideal_height=4;
    public static float max_ideal_height=6;

    public void Start()
    {
        min_ideal_height = 4;
        max_ideal_height = 6;
    }

    public override void AcademyReset()
    {
        for (int i = 0; i < agents.Length; i++)
                    agents[i].GetComponent<ChopterAgent>().ideal_height = Random.Range(min_ideal_height, max_ideal_height);
    }
}
