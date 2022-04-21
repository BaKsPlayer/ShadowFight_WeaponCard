using UnityEngine;

public class WeaponButton : MonoBehaviour
{
    [Header("Weapon description:")]
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private WeaponType _weaponType;
    public WeaponType WeaponType => _weaponType;

    [SerializeField] private WeaponStats _weaponStats;
    public WeaponStats WeaponStats => _weaponStats;

    [SerializeField] private WeaponTalent _firstTalent;
    public WeaponTalent FirstTalent => _firstTalent;

    [SerializeField] private WeaponTalent _secondTalent;
    public WeaponTalent SecondTalent => _secondTalent;

    [Header("Links:")]
    [SerializeField] private WeaponTooltip _tooltip;

    public void Select()
    {
        _tooltip.Fill(this);
    }
}

[System.Serializable]
public class WeaponStats
{
    [Range(0, 100)]
    [SerializeField] private int _damage;
    public int Damage => _damage;

    [Range(0, 100)]
    [SerializeField] private int _criticalDamage;
    public int CriticalDamage => _criticalDamage;

    [Range(0, 100)]
    [SerializeField] private int _magic;
    public int Magic => _magic;
}

[System.Serializable]
public class WeaponTalent
{
    [SerializeField] private string _name;
    public string Name => _name;

    [TextArea(minLines: 1, maxLines: 5)]
    [SerializeField] private string _description;
    public string Description => _description;
}
