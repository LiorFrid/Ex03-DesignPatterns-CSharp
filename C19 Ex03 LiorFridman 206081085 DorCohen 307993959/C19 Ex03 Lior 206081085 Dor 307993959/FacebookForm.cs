using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C19_Ex03_LiorFridman_206081085_DorCohen_307993959
{
    public partial class FacebookForm : Form
    {
		private readonly object sr_MatchFeatureLocker = new object();

		private FacebookManager m_FacebookManager;

		public FacebookForm()
        {
            this.InitializeComponent();
            m_FacebookManager = FacebookManager.GetInstance();

            if (m_FacebookManager.AppSettingsInstance.RememberUser)
            {
                m_FacebookManager.AppSettingsInstance = AppSettings.GetInstance();
                this.Size = m_FacebookManager.AppSettingsInstance.LastWindowsSize;
                this.Location = m_FacebookManager.AppSettingsInstance.LastWindowLocation;
                this.m_RemberMeCheckbox.Checked = m_FacebookManager.AppSettingsInstance.RememberUser;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            try
            {
                if (m_FacebookManager.AppSettingsInstance.RememberUser)
                {
					login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void login()
		{
			m_FacebookManager.Login();
			m_RemberMeCheckbox.Enabled = true;
			m_LoginLogoutBtn.Text = "Logout";
			this.fetchUserInfo();
		}

        private void loginLogoutBtn_Click(object sender, EventArgs e)
        {
            if (m_LoginLogoutBtn.Text == "Login")
            {
				try
				{
					login();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
            else
			{
				logout();
			}
		}

		private void logout()
		{
			m_FacebookManager.Logout();
			m_RemberMeCheckbox.Enabled = false;
			m_RemberMeCheckbox.Checked = false;
			cleanUI();
			m_LoginLogoutBtn.Text = "Login";
		}

		private void cleanUI()
        {
			m_GroupListBox.DataSource = null;
			m_FriendListBox.DataSource = null;
			m_PostListBox.DataSource = null;
            m_PictureProfileFeature.Image = null;
            m_ProfilePicMain.Image = null;
        }

        private void fetchUserInfo()
        {
            try
            {
                m_ProfilePicMain.LoadAsync(m_FacebookManager.LoggedInUser.PictureNormalURL);
                this.fetchUserPosts();
                this.fetchUserFriends();
                this.fetchUserGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchUserFriends()
        {
			m_FriendListBox.DataSource = friendListBindingSource;
			m_FriendListBox.DisplayMember = "Name";
			friendListBindingSource.DataSource = m_FacebookManager.LoggedInUserFriends;
        }

        private void fetchUserGroups()
        {
			groupBindingSource.DataSource = m_FacebookManager.LoggedInUser.Groups;
        }

        private void fetchUserPosts()
        {
			postBindingSource.DataSource = m_FacebookManager.LoggedInUser.Posts;
        }

		private void postBtn_Click(object sender, EventArgs e)
		{
			FormToFillText newPost = new FormToFillText();
			newPost.ShowDialog();
			if (!string.IsNullOrEmpty(newPost.UserInput)
				&& !newPost.IsCanceled)
			{
				try
				{
					m_FacebookManager.LoggedInUser.PostStatus(newPost.UserInput);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Nothing was happened");
			}
        }

		protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_FacebookManager.AppSettingsInstance.RememberUser = this.m_RemberMeCheckbox.Checked;
            m_FacebookManager.AppSettingsInstance.LastWindowLocation = this.Location;
            m_FacebookManager.AppSettingsInstance.LastWindowsSize = this.Size;
            if (m_FacebookManager.LoginResult != null)
            {
                if (!string.IsNullOrEmpty(m_FacebookManager.LoginResult.AccessToken))
                {
                    m_FacebookManager.AppSettingsInstance.AccessToken = m_FacebookManager.LoginResult.AccessToken;
                }
            }

			try
			{
				m_FacebookManager.AppSettingsInstance.SaveToFile();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }

        private void bestPhotoBtn_Click(object sender, EventArgs e)
        {
            try
            {
				string pictures = null;
                int T = m_FacebookManager.FindBestTimeToUploadAPicture(ref pictures);
                m_BestTimeLabel.Text += T.ToString();
                if (pictures != null)
                {
                    m_BestTImePic.LoadAsync(pictures);
                }
                else
                {
                    m_BestTimeLabel.Text = "No photos, so there is your profile picture";
                    m_BestTImePic.LoadAsync(m_FacebookManager.LoggedInUser.PictureNormalURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void sortFriendsByLastNameBtn_Click(object sender, EventArgs e)
		{
			clearFriendsListBox();
			m_FacebookManager.SortFriendByFirstName();
			fetchUserFriends();
		}

		private void clearFriendsListBox()
		{
			m_FriendListBox.DataSource = null;
		}

		private void sortFriendsByFirstNameBtn_Click(object sender, EventArgs e)
		{
			clearFriendsListBox();
			m_FacebookManager.SortFriendByLastName();
			fetchUserFriends();
		}

		private void MatchByPhotosBtn_Click(object sender, EventArgs e)
		{
			new Thread(MatchByPhotos).Start();
		}

		private void MatchByPhotos()
		{
			lock (sr_MatchFeatureLocker)
			{
				try
				{
					m_FacebookManager.RunMatchByPhotos();
					setUI();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void MatchByGroupsBtn_Click(object sender, EventArgs e)
		{
			new Thread(MatchByGroup).Start();
		}

		private void MatchByGroup()
		{
			lock (sr_MatchFeatureLocker)
			{
				try
				{
					m_FacebookManager.RunMatchByGroups();
					setUI();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void MatchByFriendsBtn_Click(object sender, EventArgs e)
		{
			new Thread(MatchByFriends).Start();
		}

		private void MatchByFriends()
		{
			lock (sr_MatchFeatureLocker)
			{
				try
				{
					m_FacebookManager.RunMatchByFriends();
					setUI();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void setUI()
		{
			try
			{
				m_PictureProfileMatch.LoadAsync(m_FacebookManager.MatchFinder.IStrategyMatcher.BestMatch.PictureLargeURL);
				m_PictureProfileFeature.LoadAsync(m_FacebookManager.LoggedInUser.PictureNormalURL);
				UserChoiceForm sendEmailChoice = new UserChoiceForm(string.Format(@"Would you like send your match" +
																				"\n friend a message? "));
				sendEmailChoice.ShowDialog();
				if (sendEmailChoice.Choice)
				{
					m_FacebookManager.SendMail(m_FacebookManager.MatchFinder.IStrategyMatcher.BestMatch.Email);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}	
	}
}