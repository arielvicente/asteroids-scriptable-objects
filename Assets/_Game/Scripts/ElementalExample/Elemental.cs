using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class Elemental : MonoBehaviour
    {
        public ElementSO Element;
        
        private void OnTriggerEnter(Collider other)
        {
            var otherElemental = other.gameObject.GetComponent<Elemental>();
            if (otherElemental == null)
                return;

            //var otherElement = otherElemental.Element;
            //if (ElementFighter.Defeats[otherElement].Contains(Element))
               // Destroy(gameObject);
            
            // If we use SO
            if (otherElemental.Element.DefeatedElements.Contains(Element))
                Destroy(gameObject);
        }
    }

    public static class ElementFighter
    {
        public static readonly Dictionary<ElementEnum, ElementEnum[]> Defeats = new Dictionary<ElementEnum, ElementEnum[]>()
        {
            {ElementEnum.Rock, new[] {ElementEnum.Scissor}},
            {ElementEnum.Paper, new[] {ElementEnum.Rock}},
            {ElementEnum.Scissor, new[] {ElementEnum.Paper}},
            {ElementEnum.Banana, new[] {ElementEnum.Paper, ElementEnum.Rock, ElementEnum.Scissor}},
            
        };
    }
}
