using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex03_LiorFridman_206081085_DorCohen_307993959
{
	public class PhotosAndLikes : IEnumerable
	{
		public int TotalLikes { get; set; }

		public int NumOfPhotos { get; set; }

		public List<Photo> Pictures { get; set; }

		public PhotosAndLikes(int i_NumOfPhotos, int i_TotalLikes)
		{
			NumOfPhotos = i_NumOfPhotos;
			TotalLikes = i_TotalLikes;
			Pictures = new List<Photo>();
		}

		public IEnumerator GetEnumerator()
		{
			return Pictures.GetEnumerator();
		}
	}
}
