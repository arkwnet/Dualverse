namespace Dualverse
{
	internal class Language
	{
		private string name;
		private string code;

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

		public Language(string name, string code)
		{
			this.name = name;
			this.code = code;
		}
	}
}
