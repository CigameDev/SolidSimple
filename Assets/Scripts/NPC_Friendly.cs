using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.UI;

public class NPC_Friendly : NPC
{
    public string text = "Hi there. Look out for that KOBOLD on the other side!";

    public void Talk()
    {
        OnSpeak?.Invoke(text);
        audioSource.Play();
        
    }

    public override void Interact()
    {
        base.Interact();
    }
    protected override string GetText()
    {
        return text;
    }
}
