using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NPC_Enemy : NPC,IHitable
{
    
    public string text = "I deal 10 physical damage    ( •̀ᴗ•́ )و ̑̑ ";

    public void GetHit()
    {
        Debug.Log("Pounch");
    }

    public override void Interact()
    {
        base.Interact();
        FindObjectOfType<Player>().ReceiveDamaged();
    }
    protected override string GetText()
    {
        return text;
    }
}
