using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/PlayerInput")]
public class PlayerInput : ScriptableObject
{
    public KeyCode Forward;
    public KeyCode Backward;
    public KeyCode Right;
    public KeyCode Left;
    
    //todo: сделать свойства к полям
}
