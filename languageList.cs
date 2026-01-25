using System.Collections.Generic;

namespace Dualverse
{
	internal class LanguageList
	{
		private List<Language> languageList = new List<Language>();

		public LanguageList()
		{
			languageList.Add(new Language("日本語", "ja-JP"));
			languageList.Add(new Language("English", "en-US"));
			languageList.Add(new Language("简体中文", "zh-CN"));
			languageList.Add(new Language("繁體中文", "zh-TW"));
		}

		public int Count()
		{
			return languageList.Count;
		}

		public Language Get(int index)
		{
			return languageList[index];
		}
	}
}
