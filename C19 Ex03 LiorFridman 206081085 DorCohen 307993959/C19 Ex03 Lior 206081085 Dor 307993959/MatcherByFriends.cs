using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex03_LiorFridman_206081085_DorCohen_307993959
{
	public class MatcherByFriends : IStrategyMatcher
	{
		public User BestMatch { get; set; }

		public void FindMatch(User i_LoggedInUser)
		{
			int mutualFriends;
			int maxMutualFriends = 0;
			Random rnd = new Random();
			int num = rnd.Next(1, 10);
			User myMatchFriend = i_LoggedInUser.Friends[num];
			foreach (User friend in i_LoggedInUser.Friends)
			{
				mutualFriends = 0;
				foreach (User hisfriend in friend.Friends)
				{
					foreach (User myFriend in i_LoggedInUser.Friends)
					{
						if (hisfriend == myFriend)
						{
							mutualFriends++;
						}
					}
				}

				if (mutualFriends > maxMutualFriends)
				{
					maxMutualFriends = mutualFriends;
					myMatchFriend = friend;
				}
			}

			BestMatch = myMatchFriend;
		}
	}
}
