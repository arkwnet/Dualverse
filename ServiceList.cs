using System.Collections.Generic;

namespace Dualverse
{
	internal class ServiceList
	{
		private List<Service> serviceList = new List<Service>();

		public ServiceList() {
			serviceList.Add(new Service("X (旧Twitter)", "https://twitter.com/"));
			serviceList.Add(new Service("X Pro (旧TweetDeck)", "https://pro.twitter.com/"));
			serviceList.Add(new Service("Misskey.io", "https://misskey.io/"));
			serviceList.Add(new Service("カスタム", ""));
		}

		public int Count() {
			return serviceList.Count;
		}

		public Service Get(int index) {
			return serviceList[index];
		}
	}
}
