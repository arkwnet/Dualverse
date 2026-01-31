namespace Dualverse
{
	internal class Language
	{
		private string name;
		private string code;
		private string font;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		public string Font
		{
			get { return font; }
			set { font = value; }
		}

		public Language(string name, string code, string font)
		{
			this.name = name;
			this.code = code;
			this.font = font;
		}
	}
}
