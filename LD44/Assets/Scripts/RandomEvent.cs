using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvent : MonoBehaviour
{
    public GameObject[] eventWritten;
    public Component[] writtenEvent;
    public int numberOfEventsRequired = 7;
    public int[] UsedEvents;
    
    public int i;
    

    void Start()
    {
        writtenEvent = GetComponentsInChildren(typeof(Canvas), true);
        print(eventWritten.Length);
        print(eventWritten);
    }

    void Update()
    {
        
    }
    
}