namespace Dualverse
{
	public class Settings
	{
		private string leftUri;
		private string rightUri;

		public string LeftUri
		{
			get { return leftUri; }
			set { leftUri = value; }
		}

		public string RightUri
		{
			get { return rightUri; }
			set { rightUri = value; }
		}

		public Settings()
		{
			leftUri = "https://twitter.com/";
			rightUri = "https://misskey.io/";
		}
	}
}
