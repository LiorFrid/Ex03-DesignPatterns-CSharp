﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex03_LiorFridman_206081085_DorCohen_307993959
{
	public class MatcherByGroups : IStrategyMatcher
	{
		public User BestMatch { get; set; }

		public void FindMatch(User i_LoggedInUser)
		{
			int MutualGroups;
			int maxMutualGroups = 0;
			Random rnd = new Random();
			int num = rnd.Next(1, 10);
			User myMatch = i_LoggedInUser.Friends[num];
			foreach (User friend in i_LoggedInUser.Friends)
			{
				MutualGroups = 0;
				foreach (Group group in i_LoggedInUser.Groups)
				{
					foreach (Group friendgroup in friend.Groups)
					{
						if (friendgroup.Id == group.Id)
						{
							MutualGroups++;
						}
					}
				}

				if (MutualGroups > maxMutualGroups)
				{
					maxMutualGroups = MutualGroups;
					myMatch = friend;
				}
			}

			BestMatch = myMatch;
		}
	}
}
