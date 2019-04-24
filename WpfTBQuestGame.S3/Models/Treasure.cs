using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTBQuestGame.S2.Models
{
	public class Treasure : GameItem
	{
		public enum TreasureType
		{
			Crystal,
			Gold,
			Rock
		}

		public TreasureType Type { get; set; }

		public Treasure(int id, string name, string description, int exp, string useMessage, TreasureType type)
			: base(id, name, description, exp, useMessage)
		{
			Type = type;
		}

		public override string infoString()
		{
			return $"{Name}: {Description}";
		}
	}
}
