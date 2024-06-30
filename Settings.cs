using Dualverse.Properties;
using System.IO;

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
			leftUri = "";
			rightUri = "";
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
