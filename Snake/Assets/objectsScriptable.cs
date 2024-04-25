using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Lessons/deneme")]

public class objectsScriptable : ScriptableObject
{
    [SerializeField] private int sayi;


    public int propint { get { return sayi; } }
}
