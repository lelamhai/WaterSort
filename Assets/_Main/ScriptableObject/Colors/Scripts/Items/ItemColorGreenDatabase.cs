using UnityEngine;

[CreateAssetMenu(fileName = "New Color Green", menuName = "WaterSort/Items/Color/Green")]
public class ItemColorGreenDatabase : BaseItemColorDatabase
{
    protected override void SetInfo()
    {
        Model.Color = Color.green;
    }
}