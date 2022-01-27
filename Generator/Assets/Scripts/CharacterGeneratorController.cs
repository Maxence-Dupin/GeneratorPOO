using System;
using System.Collections.Generic;
using System.Text;
using GeneratorScript;

namespace Generator.GeneratorScript
{
	public class CharacterGeneratorController
	{
		public static CharacterGeneratorController _instanceCGC;
		protected List<CharacterData> _generatedCharacters;
		protected List<CharacterData> _availableCharacters;

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
