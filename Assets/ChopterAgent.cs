using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;
using UnityEngine.UI;

public class ChopterAgent : Agent
{
    public float ideal_height;  //as of right now should be 4
    public float threshold_from_ideal_height;
    public float max_force;
    public float max_height_threshold;
    public float max_velocity_treshold;
    public static int counter;
    public static int coll_counter;
    public static int to_counter;
    public GameObject text;
    public GameObject collisions;
    public GameObject timesouts;
    public float reward_for_debbuging;
    public Vector3 startingpoz;

    public float diff_ideal_height;

    public void Start()
    {
        counter = 0;
        coll_counter = 0;
        to_counter = 0;
        startingpoz = transform.position;
        diff_ideal_height = ChopterAcademy.max_ideal_height - ChopterAcademy.min_ideal_height;
        ideal_height = Random.Range(ChopterAcademy.min_ideal_height, ChopterAcademy.max_ideal_height);
    }

    public void FixedUpdate()
    {
        /*if (transform.position.y > 12.0f)
        {
            text.GetComponent<Text>().text = "" + counter;
            counter++;
            collisions.GetComponent<Text>().text = ""+ coll_counter;
            coll_counter++;
            transform.position = new Vector3(2.5f, 2.2f, 42);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Done();
        }

        if(transform.position.y < 0f)
        {
            transform.position = new Vector3(2.5f, 2.2f, 42);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Done();
        }*/

        if(transform.position.y>max_height_threshold)
        {
            //AddReward(-0.01f*transform.position.y/max_height_threshold);
            //AddReward(-1f);
           // transform.position = new Vector3(2.5f, max_height_threshold, 42);

        }

        if(GetComponent<Rigidbody>().velocity.y> max_velocity_treshold)
        {
            // AddReward(-0.01f * GetComponent<Rigidbody>().velocity.y / max_velocity_treshold);
            //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }

        if(transform.position.y < 0.5f)
        {
            //AddReward(-0.01f * Mathf.Abs(transform.position.y / max_height_threshold));
            //transform.position = new Vector3(2.5f, 0.5f, 42);
            //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //Done();
        }
            
    }

    public float HeightLossFunction(float current_h)
    {
        if (Mathf.Abs(current_h - ideal_height) <= threshold_from_ideal_height)
            return 1-Mathf.Abs((current_h - ideal_height) / (threshold_from_ideal_height));

        if (current_h >ideal_height)
            return -Mathf.Abs((current_h - ideal_height) / (ideal_height + max_height_threshold));
        return -Mathf.Abs((Mathf.Abs(current_h) - (ideal_height-threshold_from_ideal_height)) / (ideal_height-threshold_from_ideal_height));
        //return 1+1f /Mathf.Exp(1f/(1f+Mathf.Exp(-Mathf.Abs(ideal_height - current_h))));
        //return -1f / (1f + Mathf.Exp(-Mathf.Abs(ideal_height - current_h)));
        //return 0;

    }

    public override void InitializeAgent()
    {
        //counter = 0;
    }

    public override void CollectObservations()
    {
        if (transform.position.y > max_height_threshold)
            AddVectorObs(1);
        else
            if (transform.position.y < -max_height_threshold)
                AddVectorObs(-1);
            else
                AddVectorObs(transform.position.y / max_height_threshold);

        if (GetComponent<Rigidbody>().velocity.y > max_velocity_treshold)
            AddVectorObs(1);
        else
            if (GetComponent<Rigidbody>().velocity.y < -max_velocity_treshold)
            AddVectorObs(-1);
        else
            AddVectorObs(GetComponent<Rigidbody>().velocity.y / max_velocity_treshold);

        AddVectorObs(ideal_height/(ChopterAcademy.max_ideal_height-ChopterAcademy.min_ideal_height));
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        if(brain.brainParameters.vectorActionSpaceType == SpaceType.continuous)
        {
            if (transform.position.y > max_height_threshold+ideal_height)
            {
                transform.position = new Vector3(startingpoz.x, max_height_threshold, startingpoz.z);
            }
            else
                if (transform.position.y < 0.0f)
                {
                    transform.position = new Vector3(startingpoz.x, 0.0f, transform.localPosition.z);
                    GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0); 
                }
                else
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.up * vectorAction[0] * max_force);
                    if (GetComponent<Rigidbody>().velocity.y > max_velocity_treshold)
                        GetComponent<Rigidbody>().velocity = new Vector3(0f, max_velocity_treshold, 0f);     
                }

            AddReward(HeightLossFunction(transform.position.y));
         
        }
    }

    //Done();
    //AddReward(HeightLossFunction(transform.position.y));
    // reward_for_debbuging = HeightLossFunction(transform.position.y);
    // GetComponent<Rigidbody>().AddForce(Vector3.up * Mathf.Clamp(vectorAction[0],-1f,1f)*max_force);
    //AddReward(-0.01f * Mathf.Abs(transform.position.y / max_height_threshold));
    //Debug.Log("======================");
    //Debug.Log("Output:"+vectorAction[0]+" Loss: "+ HeightLossFunction(transform.position.y) + " Velocity:" + GetComponent<Rigidbody>().velocity + "Height:" + transform.position.y);

    public void OnCollisionEnter(Collision collision)
    {
        //AddReward(-1f);
        /*collisions.GetComponent<Text>().text = "" + coll_counter;
        coll_counter++;*/
        //Done();
        //AgentReset();
    }

    public override void AgentReset()
    {
        //ideal_height = Random.Range(ChopterAcademy.min_ideal_height, ChopterAcademy.max_ideal_height);
        //transform.position = new Vector3(2.5f, 2.2f, 42);
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        /*text.GetComponent<Text>().text = "" + counter;
        counter++;
        timesouts.GetComponent<Text>().text = "" + to_counter;
        to_counter++;*/
    }

}
