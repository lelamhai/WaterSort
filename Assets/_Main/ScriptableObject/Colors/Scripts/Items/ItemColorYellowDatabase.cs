using UnityEngine;

[CreateAssetMenu(fileName = "New Color Yellow", menuName = "WaterSort/Items/Color/Yellow")]
public class ItemColorYellowDatabase : BaseItemColorDatabase
{
    protected override void SetInfo()
    {
        Model.Color = Color.yellow;
    }
}