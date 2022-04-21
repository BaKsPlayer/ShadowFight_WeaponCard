using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponTooltip : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private TextMeshProUGUI _typeText;

    [SerializeField] private TooltipStats _tooltipStats;
    [SerializeField] private TooltipTalents _tooltipTalents;

    public void Fill(WeaponButton button)
    {
        _titleText.text = button.Name.ToUpper();
        _typeText.text = button.WeaponType.ToString();

        _tooltipStats.Fill(button);
        _tooltipTalents.Fill(button);

        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
    }
}
