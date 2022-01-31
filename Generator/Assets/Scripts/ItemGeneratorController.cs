using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Generator.GeneratorScript
{
	public class ItemGeneratorController : MonoBehaviour
	{
		public static ItemGeneratorController _instanceIGC = null;
		protected Item _generatedItem;
		protected List<Item> _availableItems;

		private void Awake()
		{
			_instanceIGC = this;
		}

		private void Start()
        {
			_availableItems = new List<Item>();
			_availableItems.Add(new OffensiveItem("Anneau rouge", 3, DamageType.MAGIC_DAMAGE));
			_availableItems.Add(new OffensiveItem("Épée kicoupe", 12, DamageType.MELEE_DAMAGE));
			_availableItems.Add(new OffensiveItem("Gatling", 50, DamageType.PROJECTILE_DAMAGE));
			_availableItems.Add(new DefensiveItem("Manteau de la nuit", DamageType.MAGIC_DAMAGE));
			_availableItems.Add(new DefensiveItem("Plastron gargantuesque", DamageType.MELEE_DAMAGE));
			_availableItems.Add(new DefensiveItem("Bouclier 3*3 px", DamageType.PROJECTILE_DAMAGE));
		}

		public static ItemGeneratorController GetInstance
		{
			get => _instanceIGC;
		}

		public Item GenerateItem(ItemType itemType)
		{
			List<Item> _items = new List<Item>();
			switch (itemType)
            {
				case ItemType.OFFENSIVE:
					foreach(Item item in _availableItems)
                    {
						if(item is OffensiveItem)
                        {
							_items.Add(item);
                        }
                    }
					break;

				case ItemType.DEFENSIVE:
					foreach (Item item in _availableItems)
					{
						if (item is DefensiveItem)
						{
							_items.Add(item);
						}
					}
					break;

				default:
					break;
            }

			_generatedItem = _items[UnityEngine.Random.Range(0, _items.Count)];
			return _generatedItem;
		}
	}
}
