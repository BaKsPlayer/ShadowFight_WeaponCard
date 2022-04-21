using TMPro;
using UnityEngine;

public class TooltipTalents : MonoBehaviour
{
    [Header("First Talent:")]
    [SerializeField] private GameObject _firstTalentBlock;
    [SerializeField] private TextMeshProUGUI _firstTalentTitleText;
    [SerializeField] private TextMeshProUGUI _firstTalentDescriptionText;

    [Header("Second Talent:")]
    [SerializeField] private GameObject _secondTalentBlock;
    [SerializeField] private TextMeshProUGUI _secondTalentTitleText;
    [SerializeField] private TextMeshProUGUI _secondTalentDescriptionText;

    public void Fill(WeaponButton button)
    {
        if (button.FirstTalent.Name != string.Empty)
        {
            _firstTalentTitleText.text = button.FirstTalent.Name;
            _firstTalentDescriptionText.text = button.FirstTalent.Description;
            _firstTalentBlock.SetActive(true);
        }
        else
            _firstTalentBlock.SetActive(false);

        if (button.SecondTalent.Name != string.Empty)
        {
            _secondTalentTitleText.text = button.SecondTalent.Name;
            _secondTalentDescriptionText.text = button.SecondTalent.Description;
            _secondTalentBlock.SetActive(true);
        }
        else
            _secondTalentBlock.SetActive(false);
    }
}
