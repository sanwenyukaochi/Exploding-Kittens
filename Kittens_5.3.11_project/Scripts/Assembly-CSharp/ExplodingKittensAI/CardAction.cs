using System.Collections.Generic;

namespace ExplodingKittensAI
{
	public class CardAction
	{
		public bool Diarrhea;

		public bool CatButted;

		public string Type { get; set; }

		public string Name { get; set; }

		public int KittenPlacement { get; set; }

		public IList<CardAction> Deck { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
