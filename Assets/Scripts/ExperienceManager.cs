using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    int index = 0;
    // Start is called before the first frame update
    void Awake()
    {
        ChangeExperience(0);
    }
    // Update is called once per frame
    public void ChangeExperience(int change)
    {
        if (index == transform.childCount-1 && change == 1)
            index = 0;
        else if (index == 0 && change == -1)
            index = transform.childCount-1;
        else   
            index += change;

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }
}
