namespace Dualverse
{
	internal class Service
	{
		private string name;
		private string uri;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Uri
		{
			get { return uri; }
			set { uri = value; }
		}

		public Service(string name, string uri)
		{
			this.name = name;
			this.uri = uri;
		}
	}
}
