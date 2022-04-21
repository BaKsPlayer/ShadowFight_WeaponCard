using TMPro;
using UnityEngine;

public class TooltipStats : MonoBehaviour
{
    [Header("Damage:")]
    [SerializeField] private GameObject _damageBlock;
    [SerializeField] private TextMeshProUGUI _damageText;

    [Header("Critical Damage:")]
    [SerializeField] private GameObject _criticalDamageBlock;
    [SerializeField] private TextMeshProUGUI _criticalDamageText;

    [Header("Magic:")]
    [SerializeField] private GameObject _magicBlock;
    [SerializeField] private TextMeshProUGUI _magicText;

    public void Fill(WeaponButton button)
    {
        if (button.WeaponStats.Damage > 0)
        {
            _damageText.text = $"+ {button.WeaponStats.Damage}%";
            _damageBlock.SetActive(true);
        }
        else
            _damageBlock.SetActive(false);

        if (button.WeaponStats.CriticalDamage > 0)
        {
            _criticalDamageText.text = $"+ {button.WeaponStats.CriticalDamage}%";
            _criticalDamageBlock.SetActive(true);
        }
        else
            _criticalDamageBlock.SetActive(false);

        if (button.WeaponStats.Magic > 0)
        {
            _magicText.text = $"+ {button.WeaponStats.Magic}%";
            _magicBlock.SetActive(true);
        }
        else
            _magicBlock.SetActive(false);
    }
}
