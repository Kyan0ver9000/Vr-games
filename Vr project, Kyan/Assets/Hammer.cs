using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State { Throw,Return,Idle }
public class Hammer : MonoBehaviour
{
    public float hammerspeed;
    Rigidbody rb;
    State state;
    public Transform playerHand;
    void Start()
    {
        state = State.Idle;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       switch (state)
        {
            case State.Throw:
                {
                    rb.velocity = rb.velocity.normalized * hammerspeed;
                }
                break;

            case State.Idle:
                {

                }
                break;

            case State.Return:
                {
                    if (Vector3.SqrMagnitude(playerHand.position - transform.position) < 16)
                    {
                        Vector3 dir = (playerHand.position - transform.position).normalized;
                        rb.velocity = dir * hammerspeed;
                    }
                    else
                    {
                        state = State.Idle;
                    }
                    
                }
                break;

            default: 
                break;
            
        }   
    }
    public void ThrowHammer()
    {
        state = State.Throw;
    }
    public void ReturnHammer()
    {
        state = State.Return;
    }
    public void IdleHammer()
    {
        state = State.Idle;
    }


    }
    


    
        
    

