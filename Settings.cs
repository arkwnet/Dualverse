using System.IO;

namespace Dualverse
{
	public class Settings
	{
		private string leftUri;
		private string rightUri;
		private string language;

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

		public string Language
		{
			get { return language; }
			set { language = value; }
		}

		public Settings()
		{
			leftUri = "";
			rightUri = "";
			language = "";
		}

		public void Save(string fileName)
		{
			System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
			StreamWriter streamWriter = new StreamWriter(fileName, false, new System.Text.UTF8Encoding(false));
			serializer.Serialize(streamWriter, this);
			streamWriter.Close();
		}
	}
}
