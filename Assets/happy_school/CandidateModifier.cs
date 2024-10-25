using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class CandidateModifier : MonoBehaviour
{
    public Image Player;
    public Transform Playertransform;
    public Image HairColor;
    public Image[] Professions;
    
    public int Professions_Int;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Professions.Length; i++)
        {
            if (i == Professions_Int)
            {
                Professions[i].enabled = true;
            }
            else
            {
                Professions[i].enabled = false;
            }
        }
    }
    public void Profession_Selector(int value)
    {
        Professions_Int = value;
    }
    public void HairColor_Selector(int value)
    {
        if (value == 0)
        {
            HairColor.color = Color.white;
        }
        else if (value == 1)
        {
            HairColor.color = Color.red;
        }
        else if (value == 2)
        {
            HairColor.color = Color.blue;
        }
        else if (value == 3)
        {
            HairColor.color = Color.yellow;
        }
    }
    public void BodyColor_Selector(int value)
    {
        if (value == 0)
        {
            Player.color = Color.white;
        }
        else if (value == 1)
        {
            Player.color = Color.gray;
        }
        else if (value == 2)
        {
            Player.color = Color.blue;
        }
        else if (value == 3)
        {
            Player.color = Color.yellow;
        }
    }
    public void HeightSelector(float value)
    {
        Vector3 newScale = Playertransform.localScale;
        newScale.y = value;  // Adjust the height (y-axis)
        Playertransform.localScale = newScale;  // Apply the new scale
    }

    public void PhysiqueSelector(float value)
    {
        Vector3 newScale = Playertransform.localScale;
        newScale.x = value;  // Adjust the width (x-axis) for physique
        Playertransform.localScale = newScale;  // Apply the new scale
    }

}
