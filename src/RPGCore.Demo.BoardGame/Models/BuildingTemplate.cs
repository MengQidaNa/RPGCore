﻿using RPGCore.Behaviour;

namespace RPGCore.Demo.BoardGame.Models
{
	public class BuildingTemplate
	{
		public string DisplayName;

		public string[,] Recipe;

		public Graph GlobalEffectGraph;
		public Graph LocalEffectGraph;
	}
}
