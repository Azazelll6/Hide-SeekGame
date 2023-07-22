using UnityEngine;

[CreateAssetMenu(fileName = "ClickData", menuName = "UtilitySO/ClickData")]
public class ClickData : ScriptableObject
{
    [HideInInspector] public float timeStart, timeEnd, force;
    [HideInInspector] public Vector2 positionCurrent, positionStart, positionEnd, direction;
    [HideInInspector] public Vector3 hitPoint;
    [HideInInspector] public GameObject hitObj;
}
