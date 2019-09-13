using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex03_LiorFridman_206081085_DorCohen_307993959
{
	public class MatchFinderFeature
	{
		public IStrategyMatcher IStrategyMatcher { get; set; }

		public MatchFinderFeature(IStrategyMatcher i_StrategyMatcher)
		{
			IStrategyMatcher = i_StrategyMatcher;
		}

		public void FindMatch(User i_LoggedInUser)
		{
			IStrategyMatcher.FindMatch(i_LoggedInUser);
		}
	}
}
