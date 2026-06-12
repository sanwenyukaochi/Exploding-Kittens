public class BlacklistedNameReplacer : UserInputTransformer
{
	private const string WHITELISTED_CHARACTERS = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";

	public override string Transform(string original)
	{
		return null;
	}

	public string ReplaceBlacklistedNameIfNecessary(string newUsername)
	{
		return null;
	}

	private bool StringContainsBlacklistedWord(string stringToTest)
	{
		return false;
	}

	private bool StringContainsBlacklistedCharacters(string stringToTest)
	{
		return false;
	}
}
