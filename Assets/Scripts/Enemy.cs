using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;



public class Enemy : MonoBehaviour
{

    static public int deathCount;

    Animator animator;

    public float Health
    {
        set 
        {
            health = value;
            if (health <= 0)
            {
                Defeated();
            }
        }
        get 
        {
            return health;
        }
    }

    public float health = 1;

    private void Start()
    {
        animator = GetComponent<Animator>();


    }


    public void Defeated()
    {
        animator.SetTrigger("Defeated");

        deathCount += 1;

    }

    public void RemoveEnemy()
    {
        Destroy(gameObject);
    }


}