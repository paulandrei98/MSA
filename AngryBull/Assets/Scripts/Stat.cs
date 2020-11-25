
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField]
    private int baseValue=0;

    public int GetValue ()
    {
        return baseValue;
    }
}
