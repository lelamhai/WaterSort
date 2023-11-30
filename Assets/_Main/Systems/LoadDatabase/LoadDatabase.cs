using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadDatabase : BaseMonoBehaviour, IDataPersistence
{
    //[SerializeField] private KnifesDatabase _knifesDatabase;
    //[SerializeField] private PriceDatabase _priceDatabase;
    //[SerializeField] private LevelDatabase _levelDatabase;
    //[SerializeField] private SoundDatabase _soundDatabase;
    //[SerializeField] private GiftRewardDatabase _giftReward;
    //[SerializeField] private VibratorDatabase _vibratorDatabase;
    private void Awake()
    {
        RegisterData();
    }

    private void Start()
    {
        SceneManager.LoadSceneAsync("GamePlay");
    }

    public void RegisterData()
    {
        DataPersistanceManager.Instance.RegisterEventDataPersistance(this);
    }

    public void LoadData(GameData data)
    {
        //LoadKnife(data);
        //LoadPrice(data);
        //LoadLevel(data);
        //LoadSound(data);
        //LoadGift(data);
        //LoadVibrator(data);
    }

    //private void LoadVibrator(GameData data)
    //{
    //    _vibratorDatabase.Vibration = data.Vibration;
    //}

    //private void LoadGift(GameData data)
    //{
    //    _giftReward.Time = data.Gift.Time;
    //    _giftReward.Price = data.Gift.Price;
    //}

    

    //private void LoadKnife(GameData data)
    //{
    //    for (int i = 0; i < _knifesDatabase.Database.Count; i++)
    //    {
    //        _knifesDatabase.Database[i].Model = data.Knife[i];
    //    }
    //}

    //private void LoadPrice(GameData data)
    //{
    //    _priceDatabase.Price = data.Price;
    //}

    //private void LoadLevel(GameData data)
    //{
    //    _levelDatabase.Level = data.Level;
    //}

    //private void LoadSound(GameData data)
    //{
    //    _soundDatabase.VolumeBG = data.Sound.VolumeBG;
    //    _soundDatabase.VolumeFX = data.Sound.VolumeFX;
    //}

    public void SaveData(GameData data)
    { }
    protected override void SetDefaultValue()
    {}
}