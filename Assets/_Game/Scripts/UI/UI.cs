using TMPro;
using UnityEngine;
using Variables;

namespace UI
{
    public class UI : MonoBehaviour
    {
        [Header("Scene References:")] [SerializeField]
        private TextMeshProUGUI _healthText;
        
        [Header("Observables:")]
        [SerializeField] private FloatObservable _healthObservable;

        private void Start()
        {
            _healthObservable.Register(OnHealthChanged);
        }
        private void OnHealthChanged(float newHealth)
        {
            _healthText.text = $"Health: {newHealth}";
        }
    }
}
