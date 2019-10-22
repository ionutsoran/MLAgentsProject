using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckReward : MonoBehaviour
{
    public Color goodcolor;
    public Color neutralcolor;
    public Color badcolor;
    // Update is called once per frame
    void Update()
    {
        float someval = GetComponentInParent<ChopterAgent>().reward_for_debbuging;
        if(someval>=0)
        {
            Color tempcol = Color.Lerp(neutralcolor, goodcolor, someval);
            GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Color");
            GetComponent<Renderer>().material.SetColor("_Color", tempcol);
        }
        else
        {
            Color tempcol = Color.Lerp(neutralcolor, badcolor, Mathf.Abs(someval));
            GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Color");
            GetComponent<Renderer>().material.SetColor("_Color", tempcol);
        }
        

    }
}
