using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Text;

namespace System.ComponentModel
{
	public class MaskedTextProvider : ICloneable
	{
		private enum CaseConversion
		{
			None = 0,
			ToLower = 1,
			ToUpper = 2
		}

		[Flags]
		private enum CharType
		{
			EditOptional = 1,
			EditRequired = 2,
			Separator = 4,
			Literal = 8,
			Modifier = 0x10
		}

		private class CharDescriptor
		{
			public int MaskPosition;

			public CaseConversion CaseConversion;

			public CharType CharType;

			public bool IsAssigned;

			public CharDescriptor(int maskPos, CharType charType)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private const char SPACE_CHAR = ' ';

		private const char DEFAULT_PROMPT_CHAR = '_';

		private const char NULL_PASSWORD_CHAR = '\0';

		private const bool DEFAULT_ALLOW_PROMPT = true;

		private const int INVALID_INDEX = -1;

		private const byte EDIT_ANY = 0;

		private const byte EDIT_UNASSIGNED = 1;

		private const byte EDIT_ASSIGNED = 2;

		private const bool FORWARD = true;

		private const bool BACKWARD = false;

		private static int s_ASCII_ONLY;

		private static int s_ALLOW_PROMPT_AS_INPUT;

		private static int s_INCLUDE_PROMPT;

		private static int s_INCLUDE_LITERALS;

		private static int s_RESET_ON_PROMPT;

		private static int s_RESET_ON_LITERALS;

		private static int s_SKIP_SPACE;

		private static Type s_maskTextProviderType;

		private BitVector32 _flagState;

		private StringBuilder _testString;

		private int _requiredCharCount;

		private int _requiredEditChars;

		private int _optionalEditChars;

		private char _passwordChar;

		private char _promptChar;

		private List<CharDescriptor> _stringDescriptor;

		public bool AllowPromptAsInput => false;

		public int AssignedEditPositionCount { get; private set; }

		public int AvailableEditPositionCount => 0;

		public CultureInfo Culture { get; }

		public static char DefaultPasswordChar => '\0';

		public int EditPositionCount => 0;

		public IEnumerator EditPositions => null;

		public bool IncludeLiterals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IncludePrompt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AsciiOnly => false;

		public bool IsPassword
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int InvalidIndex => 0;

		public int LastAssignedPosition => 0;

		public int Length => 0;

		public string Mask { get; }

		public bool MaskCompleted => false;

		public bool MaskFull => false;

		public char PasswordChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		public char PromptChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		public bool ResetOnPrompt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ResetOnSpace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SkipLiterals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public char this[int index] => '\0';

		public MaskedTextProvider(string mask)
		{
		}

		public MaskedTextProvider(string mask, bool restrictToAscii)
		{
		}

		public MaskedTextProvider(string mask, CultureInfo culture)
		{
		}

		public MaskedTextProvider(string mask, CultureInfo culture, bool restrictToAscii)
		{
		}

		public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput)
		{
		}

		public MaskedTextProvider(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput)
		{
		}

		public MaskedTextProvider(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii)
		{
		}

		private void Initialize()
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool Add(char input)
		{
			return false;
		}

		public bool Add(char input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public bool Add(string input)
		{
			return false;
		}

		public bool Add(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public void Clear()
		{
		}

		public void Clear(out MaskedTextResultHint resultHint)
		{
			resultHint = default(MaskedTextResultHint);
		}

		public int FindAssignedEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		public int FindEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		public int FindEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, byte assignedStatus)
		{
			return 0;
		}

		public int FindNonEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		private int FindPositionInRange(int startPosition, int endPosition, bool direction, CharType charTypeFlags)
		{
			return 0;
		}

		public int FindUnassignedEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		public static bool GetOperationResultFromHint(MaskedTextResultHint hint)
		{
			return false;
		}

		public bool InsertAt(char input, int position)
		{
			return false;
		}

		public bool InsertAt(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public bool InsertAt(string input, int position)
		{
			return false;
		}

		public bool InsertAt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool InsertAtInt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private static bool IsAscii(char c)
		{
			return false;
		}

		private static bool IsAciiAlphanumeric(char c)
		{
			return false;
		}

		private static bool IsAlphanumeric(char c)
		{
			return false;
		}

		private static bool IsAsciiLetter(char c)
		{
			return false;
		}

		public bool IsAvailablePosition(int position)
		{
			return false;
		}

		public bool IsEditPosition(int position)
		{
			return false;
		}

		private static bool IsEditPosition(CharDescriptor charDescriptor)
		{
			return false;
		}

		private static bool IsLiteralPosition(CharDescriptor charDescriptor)
		{
			return false;
		}

		private static bool IsPrintableChar(char c)
		{
			return false;
		}

		public static bool IsValidInputChar(char c)
		{
			return false;
		}

		public static bool IsValidMaskChar(char c)
		{
			return false;
		}

		public static bool IsValidPasswordChar(char c)
		{
			return false;
		}

		public bool Remove()
		{
			return false;
		}

		public bool Remove(out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public bool RemoveAt(int position)
		{
			return false;
		}

		public bool RemoveAt(int startPosition, int endPosition)
		{
			return false;
		}

		public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool RemoveAtInt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public bool Replace(char input, int position)
		{
			return false;
		}

		public bool Replace(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public bool Replace(string input, int position)
		{
			return false;
		}

		public bool Replace(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private void ResetChar(int testPosition)
		{
		}

		private void ResetString(int startPosition, int endPosition)
		{
		}

		public bool Set(string input)
		{
			return false;
		}

		public bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private void SetChar(char input, int position)
		{
		}

		private void SetChar(char input, int position, CharDescriptor charDescriptor)
		{
		}

		private void SetString(string input, int testPosition)
		{
		}

		private bool TestChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool TestEscapeChar(char input, int position)
		{
			return false;
		}

		private bool TestEscapeChar(char input, int position, CharDescriptor charDex)
		{
			return false;
		}

		private bool TestSetChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool TestSetString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool TestString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		public string ToDisplayString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(bool ignorePasswordChar)
		{
			return null;
		}

		public string ToString(int startPosition, int length)
		{
			return null;
		}

		public string ToString(bool ignorePasswordChar, int startPosition, int length)
		{
			return null;
		}

		public string ToString(bool includePrompt, bool includeLiterals)
		{
			return null;
		}

		public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return null;
		}

		public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return null;
		}

		public bool VerifyChar(char input, int position, out MaskedTextResultHint hint)
		{
			hint = default(MaskedTextResultHint);
			return false;
		}

		public bool VerifyEscapeChar(char input, int position)
		{
			return false;
		}

		public bool VerifyString(string input)
		{
			return false;
		}

		public bool VerifyString(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}
	}
}
