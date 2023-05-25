using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAIInteractions : MonoBehaviour
{
    public Transform raycastPoint;

    public void Interact(bool isSpriteFlipped)
    {
        Debug.DrawRay(raycastPoint.position, isSpriteFlipped ? Vector3.left : Vector3.right, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(raycastPoint.position, isSpriteFlipped ? Vector3.left : Vector3.right, 1);
        if (hit.collider != null)
        {
            //if (hit.collider.GetComponent<NPC_Enemy>())
            //{
            //    hit.collider.GetComponent<NPC_Enemy>().GetHit();
            //}
            //else if (hit.collider.GetComponent<NPC_Friendly>())
            //{
            //    hit.collider.GetComponent<NPC_Friendly>().Talk();
            //}

            if(hit.collider.GetComponent<NPC>())
            {
                hit.collider.GetComponent<NPC>().Interact();
            }    

             var hitable = hit.collider.GetComponent<IHitable>();
            hitable?.GetHit();//Friendly khong co hitable nen phai kiem tra truoc khi tan cong

            /* 
                + Ca Enemy va Friendly deu la NPC
                + Deu co phuong thuc Interact ,nhung moi con lai co interact khac nhau
             */
        }

    }
}
