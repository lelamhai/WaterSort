using UnityEngine;

[CreateAssetMenu(fileName = "New Color Blue", menuName = "WaterSort/Items/Color/Blue")]
public class ItemColorBlueDatabase : BaseItemColorDatabase
{
    protected override void SetInfo()
    {
        Model.Color = Color.blue;
    }
}