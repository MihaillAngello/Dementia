﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[CreateAssetMenu (menuName = "Conversation")]

public class Conversation : ScriptableObject
{
    public string conversationId;
    private int _audioIndex;
    private int index = -1;
    [SerializeField] private Narrative[] lines;

    public Narrative GetNextLine()
    {
        index++;
        
        if (index < lines.Length)
        {
            return lines[index];
        }
        return null;
    }

    public void Reset()
    {
        index = -1;
    }
}
