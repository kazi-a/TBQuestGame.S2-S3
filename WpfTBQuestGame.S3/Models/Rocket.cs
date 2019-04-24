﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTBQuestGame.S2.Models
{
	public class Rocket : GameItem
	{
		public enum UseActionType
		{
			OPENLOCATION,
			CREWNEEDED
		}

		public UseActionType UseAction { get; set; }
		public bool CanUse { get; set; }

		public Rocket(int id, string name, string description, int exp, string useMessage, UseActionType useAction, bool CanUse)
			: base(id, name, description, exp, useMessage)
		{
			UseAction = useAction;
		}

		public override string infoString()
		{
			return $"{Name}: {Description}";
		}
	}
}
