using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public enum State
    {
        Idle, Sending, Returning, Working, Resting, Eating
    }
}
