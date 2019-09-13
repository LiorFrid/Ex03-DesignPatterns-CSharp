using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex03_LiorFridman_206081085_DorCohen_307993959
{
	public interface IStrategyMatcher
	{
		User BestMatch { get; set; }

		void FindMatch(User i_LoggedInUser);
	}
}
