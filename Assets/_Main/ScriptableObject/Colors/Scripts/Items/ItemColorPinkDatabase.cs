using UnityEngine;

[CreateAssetMenu(fileName = "New Color Pink", menuName = "WaterSort/Items/Color/Pink")]
public class ItemColorPinkDatabase : BaseItemColorDatabase
{
    protected override void SetInfo()
    {
        Model.Color = new Color(255/255, 0, 255/255);
    }
}