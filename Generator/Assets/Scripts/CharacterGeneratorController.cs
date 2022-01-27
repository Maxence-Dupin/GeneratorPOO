using System;
using System.Collections.Generic;
using System.Text;

namespace Generator.GeneratorScript
{
	public class CharacterGeneratorController
	{
		public static CharacterGeneratorController _instanceCGC;
		protected List<Character> _generatedCharacters;
		protected List<Character> _availableCharacters;

		public static CharacterGeneratorController GetInstance()
		{
			throw new NotImplementedException();
		}

		public void generateCharacter()
		{
			throw new NotImplementedException();
		}

		public void displayCharacters()
		{
			throw new NotImplementedException();
		}
	}
}
