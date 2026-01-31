using System.Collections.Generic;

namespace Dualverse
{
	internal class LanguageList
	{
		private List<Language> languageList = new List<Language>();

		public LanguageList()
		{
			languageList.Add(new Language("日本語", "ja-JP", "Yu Gothic UI"));
			languageList.Add(new Language("English", "en-US", "Segoe UI"));
			languageList.Add(new Language("简体中文", "zh-CN", "Microsoft YaHei UI"));
			languageList.Add(new Language("繁體中文", "zh-TW", "Microsoft JhengHei UI"));
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
