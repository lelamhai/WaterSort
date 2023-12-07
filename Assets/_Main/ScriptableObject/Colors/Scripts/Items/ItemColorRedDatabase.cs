using UnityEngine;

[CreateAssetMenu(fileName = "New Color Red", menuName = "WaterSort/Items/Color/Red")]
public class ItemColorRedDatabase : BaseItemColorDatabase
{
    protected override void SetInfo()
    {
        Model.Color = Color.red;
    }
}