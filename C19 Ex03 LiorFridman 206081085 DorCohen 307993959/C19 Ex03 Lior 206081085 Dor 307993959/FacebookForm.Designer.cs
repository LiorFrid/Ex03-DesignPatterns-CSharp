namespace C19_Ex03_LiorFridman_206081085_DorCohen_307993959
{
	public partial class FacebookForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TabPage m_MainTab;
			System.Windows.Forms.Label likesCountLabel;
			System.Windows.Forms.Label createdTimeLabel;
			System.Windows.Forms.Label descriptionLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label updateTimeLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
			this.sortFriendsByLastNameBtn = new System.Windows.Forms.Button();
			this.sortFriendsByFirstNameBtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.m_FriendListBox = new System.Windows.Forms.ListBox();
			this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.likesCountLabel1 = new System.Windows.Forms.Label();
			this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel1 = new System.Windows.Forms.Label();
			this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.m_GroupListBox = new System.Windows.Forms.ListBox();
			this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.m_RemberMeCheckbox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_PostListBox = new System.Windows.Forms.ListBox();
			this.m_PostBtn = new System.Windows.Forms.Button();
			this.m_LoginLogoutBtn = new System.Windows.Forms.Button();
			this.m_ProfilePicMain = new System.Windows.Forms.PictureBox();
			this.m_FaceBookBarPic = new System.Windows.Forms.PictureBox();
			this.secondfeature = new System.Windows.Forms.TabPage();
			this.m_BestTimeLabel = new System.Windows.Forms.Label();
			this.m_BestTImePic = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.m_BestPhotoBtn = new System.Windows.Forms.Button();
			this.m_FindMatchTab = new System.Windows.Forms.TabPage();
			this.MatchByGroupsBtn = new System.Windows.Forms.Button();
			this.MatchByPhotosBtn = new System.Windows.Forms.Button();
			this.MatchByFriendsBtn = new System.Windows.Forms.Button();
			this.m_ExplainOfMatchLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.m_PictureProfileMatch = new System.Windows.Forms.PictureBox();
			this.m_PictureProfileFeature = new System.Windows.Forms.PictureBox();
			this.m_Bar = new System.Windows.Forms.TabControl();
			m_MainTab = new System.Windows.Forms.TabPage();
			likesCountLabel = new System.Windows.Forms.Label();
			createdTimeLabel = new System.Windows.Forms.Label();
			descriptionLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			updateTimeLabel = new System.Windows.Forms.Label();
			m_MainTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FaceBookBarPic)).BeginInit();
			this.secondfeature.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_BestTImePic)).BeginInit();
			this.m_FindMatchTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileMatch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileFeature)).BeginInit();
			this.m_Bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_MainTab
			// 
			m_MainTab.AutoScroll = true;
			m_MainTab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			m_MainTab.Controls.Add(this.sortFriendsByLastNameBtn);
			m_MainTab.Controls.Add(this.sortFriendsByFirstNameBtn);
			m_MainTab.Controls.Add(this.label6);
			m_MainTab.Controls.Add(this.m_FriendListBox);
			m_MainTab.Controls.Add(likesCountLabel);
			m_MainTab.Controls.Add(this.likesCountLabel1);
			m_MainTab.Controls.Add(createdTimeLabel);
			m_MainTab.Controls.Add(this.createdTimeDateTimePicker);
			m_MainTab.Controls.Add(descriptionLabel);
			m_MainTab.Controls.Add(this.descriptionTextBox);
			m_MainTab.Controls.Add(nameLabel);
			m_MainTab.Controls.Add(this.nameLabel1);
			m_MainTab.Controls.Add(updateTimeLabel);
			m_MainTab.Controls.Add(this.updateTimeDateTimePicker);
			m_MainTab.Controls.Add(this.m_GroupListBox);
			m_MainTab.Controls.Add(this.label7);
			m_MainTab.Controls.Add(this.m_RemberMeCheckbox);
			m_MainTab.Controls.Add(this.label1);
			m_MainTab.Controls.Add(this.m_PostListBox);
			m_MainTab.Controls.Add(this.m_PostBtn);
			m_MainTab.Controls.Add(this.m_LoginLogoutBtn);
			m_MainTab.Controls.Add(this.m_ProfilePicMain);
			m_MainTab.Location = new System.Drawing.Point(4, 22);
			m_MainTab.Name = "m_MainTab";
			m_MainTab.Padding = new System.Windows.Forms.Padding(3);
			m_MainTab.Size = new System.Drawing.Size(873, 387);
			m_MainTab.TabIndex = 0;
			m_MainTab.Text = "Main";
			// 
			// sortFriendsByLastNameBtn
			// 
			this.sortFriendsByLastNameBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.sortFriendsByLastNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.sortFriendsByLastNameBtn.Location = new System.Drawing.Point(344, 335);
			this.sortFriendsByLastNameBtn.Name = "sortFriendsByLastNameBtn";
			this.sortFriendsByLastNameBtn.Size = new System.Drawing.Size(106, 44);
			this.sortFriendsByLastNameBtn.TabIndex = 25;
			this.sortFriendsByLastNameBtn.Text = "Sort by last name";
			this.sortFriendsByLastNameBtn.UseVisualStyleBackColor = false;
			this.sortFriendsByLastNameBtn.Click += new System.EventHandler(this.sortFriendsByLastNameBtn_Click);
			// 
			// sortFriendsByFirstNameBtn
			// 
			this.sortFriendsByFirstNameBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.sortFriendsByFirstNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.sortFriendsByFirstNameBtn.Location = new System.Drawing.Point(232, 335);
			this.sortFriendsByFirstNameBtn.Name = "sortFriendsByFirstNameBtn";
			this.sortFriendsByFirstNameBtn.Size = new System.Drawing.Size(106, 44);
			this.sortFriendsByFirstNameBtn.TabIndex = 24;
			this.sortFriendsByFirstNameBtn.Text = "Sort by first name";
			this.sortFriendsByFirstNameBtn.UseVisualStyleBackColor = false;
			this.sortFriendsByFirstNameBtn.Click += new System.EventHandler(this.sortFriendsByFirstNameBtn_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label6.Location = new System.Drawing.Point(227, 181);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 25);
			this.label6.TabIndex = 22;
			this.label6.Text = "Friends List";
			// 
			// m_FriendListBox
			// 
			this.m_FriendListBox.DataSource = this.friendListBindingSource;
			this.m_FriendListBox.DisplayMember = "Name";
			this.m_FriendListBox.FormattingEnabled = true;
			this.m_FriendListBox.Location = new System.Drawing.Point(232, 208);
			this.m_FriendListBox.Name = "m_FriendListBox";
			this.m_FriendListBox.Size = new System.Drawing.Size(216, 121);
			this.m_FriendListBox.TabIndex = 21;
			// 
			// friendListBindingSource
			// 
			this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
			// 
			// likesCountLabel
			// 
			likesCountLabel.AutoSize = true;
			likesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			likesCountLabel.Location = new System.Drawing.Point(484, 324);
			likesCountLabel.Name = "likesCountLabel";
			likesCountLabel.Size = new System.Drawing.Size(80, 16);
			likesCountLabel.TabIndex = 19;
			likesCountLabel.Text = "Likes Count:";
			// 
			// likesCountLabel1
			// 
			this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.commentsBindingSource, "LikesCount", true));
			this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "LikesCount", true));
			this.likesCountLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.likesCountLabel1.Location = new System.Drawing.Point(590, 324);
			this.likesCountLabel1.Name = "likesCountLabel1";
			this.likesCountLabel1.Size = new System.Drawing.Size(100, 23);
			this.likesCountLabel1.TabIndex = 20;
			this.likesCountLabel1.Text = "label8";
			// 
			// commentsBindingSource
			// 
			this.commentsBindingSource.DataMember = "Comments";
			this.commentsBindingSource.DataSource = this.postBindingSource;
			// 
			// postBindingSource
			// 
			this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
			// 
			// createdTimeLabel
			// 
			createdTimeLabel.AutoSize = true;
			createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			createdTimeLabel.Location = new System.Drawing.Point(484, 208);
			createdTimeLabel.Name = "createdTimeLabel";
			createdTimeLabel.Size = new System.Drawing.Size(93, 16);
			createdTimeLabel.TabIndex = 12;
			createdTimeLabel.Text = "Created Time:";
			// 
			// createdTimeDateTimePicker
			// 
			this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
			this.createdTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.createdTimeDateTimePicker.Location = new System.Drawing.Point(590, 206);
			this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
			this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.createdTimeDateTimePicker.TabIndex = 13;
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			descriptionLabel.Location = new System.Drawing.Point(484, 235);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new System.Drawing.Size(79, 16);
			descriptionLabel.TabIndex = 14;
			descriptionLabel.Text = "Description:";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true));
			this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.descriptionTextBox.Location = new System.Drawing.Point(590, 232);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
			this.descriptionTextBox.TabIndex = 15;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			nameLabel.Location = new System.Drawing.Point(484, 265);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(48, 16);
			nameLabel.TabIndex = 16;
			nameLabel.Text = "Name:";
			// 
			// nameLabel1
			// 
			this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
			this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.nameLabel1.Location = new System.Drawing.Point(590, 265);
			this.nameLabel1.Name = "nameLabel1";
			this.nameLabel1.Size = new System.Drawing.Size(200, 23);
			this.nameLabel1.TabIndex = 17;
			this.nameLabel1.Text = "label8";
			// 
			// updateTimeLabel
			// 
			updateTimeLabel.AutoSize = true;
			updateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			updateTimeLabel.Location = new System.Drawing.Point(484, 298);
			updateTimeLabel.Name = "updateTimeLabel";
			updateTimeLabel.Size = new System.Drawing.Size(90, 16);
			updateTimeLabel.TabIndex = 18;
			updateTimeLabel.Text = "Update Time:";
			// 
			// updateTimeDateTimePicker
			// 
			this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "UpdateTime", true));
			this.updateTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.updateTimeDateTimePicker.Location = new System.Drawing.Point(590, 293);
			this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
			this.updateTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.updateTimeDateTimePicker.TabIndex = 19;
			// 
			// m_GroupListBox
			// 
			this.m_GroupListBox.DataSource = this.groupBindingSource;
			this.m_GroupListBox.DisplayMember = "Name";
			this.m_GroupListBox.FormattingEnabled = true;
			this.m_GroupListBox.Location = new System.Drawing.Point(232, 57);
			this.m_GroupListBox.Name = "m_GroupListBox";
			this.m_GroupListBox.Size = new System.Drawing.Size(216, 121);
			this.m_GroupListBox.TabIndex = 11;
			// 
			// groupBindingSource
			// 
			this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label7.Location = new System.Drawing.Point(227, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Groups List";
			// 
			// m_RemberMeCheckbox
			// 
			this.m_RemberMeCheckbox.AutoSize = true;
			this.m_RemberMeCheckbox.Enabled = false;
			this.m_RemberMeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_RemberMeCheckbox.Location = new System.Drawing.Point(9, 249);
			this.m_RemberMeCheckbox.Name = "m_RemberMeCheckbox";
			this.m_RemberMeCheckbox.Size = new System.Drawing.Size(188, 24);
			this.m_RemberMeCheckbox.TabIndex = 7;
			this.m_RemberMeCheckbox.Text = "Remeber me next time";
			this.m_RemberMeCheckbox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(469, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Post\'s List";
			// 
			// m_PostListBox
			// 
			this.m_PostListBox.DataSource = this.postBindingSource;
			this.m_PostListBox.DisplayMember = "Message";
			this.m_PostListBox.FormattingEnabled = true;
			this.m_PostListBox.Location = new System.Drawing.Point(474, 57);
			this.m_PostListBox.Name = "m_PostListBox";
			this.m_PostListBox.Size = new System.Drawing.Size(357, 121);
			this.m_PostListBox.TabIndex = 5;
			this.m_PostListBox.ValueMember = "Description";
			// 
			// m_PostBtn
			// 
			this.m_PostBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_PostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_PostBtn.Location = new System.Drawing.Point(703, 11);
			this.m_PostBtn.Name = "m_PostBtn";
			this.m_PostBtn.Size = new System.Drawing.Size(116, 35);
			this.m_PostBtn.TabIndex = 3;
			this.m_PostBtn.Text = "Post something";
			this.m_PostBtn.UseVisualStyleBackColor = false;
			this.m_PostBtn.Click += new System.EventHandler(this.postBtn_Click);
			// 
			// m_LoginLogoutBtn
			// 
			this.m_LoginLogoutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_LoginLogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_LoginLogoutBtn.Location = new System.Drawing.Point(6, 6);
			this.m_LoginLogoutBtn.Name = "m_LoginLogoutBtn";
			this.m_LoginLogoutBtn.Size = new System.Drawing.Size(203, 45);
			this.m_LoginLogoutBtn.TabIndex = 1;
			this.m_LoginLogoutBtn.Text = "Login";
			this.m_LoginLogoutBtn.UseVisualStyleBackColor = false;
			this.m_LoginLogoutBtn.Click += new System.EventHandler(this.loginLogoutBtn_Click);
			// 
			// m_ProfilePicMain
			// 
			this.m_ProfilePicMain.Image = ((System.Drawing.Image)(resources.GetObject("m_ProfilePicMain.Image")));
			this.m_ProfilePicMain.Location = new System.Drawing.Point(9, 57);
			this.m_ProfilePicMain.Name = "m_ProfilePicMain";
			this.m_ProfilePicMain.Size = new System.Drawing.Size(200, 167);
			this.m_ProfilePicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_ProfilePicMain.TabIndex = 2;
			this.m_ProfilePicMain.TabStop = false;
			// 
			// m_FaceBookBarPic
			// 
			this.m_FaceBookBarPic.Image = ((System.Drawing.Image)(resources.GetObject("m_FaceBookBarPic.Image")));
			this.m_FaceBookBarPic.Location = new System.Drawing.Point(0, 6);
			this.m_FaceBookBarPic.Name = "m_FaceBookBarPic";
			this.m_FaceBookBarPic.Size = new System.Drawing.Size(881, 92);
			this.m_FaceBookBarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_FaceBookBarPic.TabIndex = 0;
			this.m_FaceBookBarPic.TabStop = false;
			// 
			// secondfeature
			// 
			this.secondfeature.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.secondfeature.Controls.Add(this.m_BestTimeLabel);
			this.secondfeature.Controls.Add(this.m_BestTImePic);
			this.secondfeature.Controls.Add(this.label5);
			this.secondfeature.Controls.Add(this.m_BestPhotoBtn);
			this.secondfeature.Location = new System.Drawing.Point(4, 22);
			this.secondfeature.Name = "secondfeature";
			this.secondfeature.Padding = new System.Windows.Forms.Padding(3);
			this.secondfeature.Size = new System.Drawing.Size(873, 387);
			this.secondfeature.TabIndex = 2;
			this.secondfeature.Text = "Best time for picture post";
			// 
			// m_BestTimeLabel
			// 
			this.m_BestTimeLabel.AutoSize = true;
			this.m_BestTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
			this.m_BestTimeLabel.Location = new System.Drawing.Point(49, 186);
			this.m_BestTimeLabel.Name = "m_BestTimeLabel";
			this.m_BestTimeLabel.Size = new System.Drawing.Size(124, 20);
			this.m_BestTimeLabel.TabIndex = 3;
			this.m_BestTimeLabel.Text = "The best time is:";
			// 
			// m_BestTImePic
			// 
			this.m_BestTImePic.Image = ((System.Drawing.Image)(resources.GetObject("m_BestTImePic.Image")));
			this.m_BestTImePic.Location = new System.Drawing.Point(376, 80);
			this.m_BestTImePic.Name = "m_BestTImePic";
			this.m_BestTImePic.Size = new System.Drawing.Size(398, 226);
			this.m_BestTImePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_BestTImePic.TabIndex = 2;
			this.m_BestTImePic.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label5.Location = new System.Drawing.Point(44, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(401, 25);
			this.label5.TabIndex = 1;
			this.label5.Text = "Click run to find the best hour for picture post!";
			// 
			// m_BestPhotoBtn
			// 
			this.m_BestPhotoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_BestPhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_BestPhotoBtn.Location = new System.Drawing.Point(44, 67);
			this.m_BestPhotoBtn.Name = "m_BestPhotoBtn";
			this.m_BestPhotoBtn.Size = new System.Drawing.Size(165, 44);
			this.m_BestPhotoBtn.TabIndex = 0;
			this.m_BestPhotoBtn.Text = "run!";
			this.m_BestPhotoBtn.UseVisualStyleBackColor = false;
			this.m_BestPhotoBtn.Click += new System.EventHandler(this.bestPhotoBtn_Click);
			// 
			// m_FindMatchTab
			// 
			this.m_FindMatchTab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.m_FindMatchTab.Controls.Add(this.MatchByGroupsBtn);
			this.m_FindMatchTab.Controls.Add(this.MatchByPhotosBtn);
			this.m_FindMatchTab.Controls.Add(this.MatchByFriendsBtn);
			this.m_FindMatchTab.Controls.Add(this.m_ExplainOfMatchLabel);
			this.m_FindMatchTab.Controls.Add(this.label3);
			this.m_FindMatchTab.Controls.Add(this.label2);
			this.m_FindMatchTab.Controls.Add(this.m_PictureProfileMatch);
			this.m_FindMatchTab.Controls.Add(this.m_PictureProfileFeature);
			this.m_FindMatchTab.Location = new System.Drawing.Point(4, 22);
			this.m_FindMatchTab.Name = "m_FindMatchTab";
			this.m_FindMatchTab.Padding = new System.Windows.Forms.Padding(3);
			this.m_FindMatchTab.Size = new System.Drawing.Size(873, 387);
			this.m_FindMatchTab.TabIndex = 1;
			this.m_FindMatchTab.Text = "Find your match";
			// 
			// MatchByGroupsBtn
			// 
			this.MatchByGroupsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.MatchByGroupsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.MatchByGroupsBtn.Location = new System.Drawing.Point(40, 125);
			this.MatchByGroupsBtn.Name = "MatchByGroupsBtn";
			this.MatchByGroupsBtn.Size = new System.Drawing.Size(203, 35);
			this.MatchByGroupsBtn.TabIndex = 17;
			this.MatchByGroupsBtn.Text = "Match by groups";
			this.MatchByGroupsBtn.UseVisualStyleBackColor = false;
			this.MatchByGroupsBtn.Click += new System.EventHandler(this.MatchByGroupsBtn_Click);
			// 
			// MatchByPhotosBtn
			// 
			this.MatchByPhotosBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.MatchByPhotosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.MatchByPhotosBtn.Location = new System.Drawing.Point(40, 184);
			this.MatchByPhotosBtn.Name = "MatchByPhotosBtn";
			this.MatchByPhotosBtn.Size = new System.Drawing.Size(203, 35);
			this.MatchByPhotosBtn.TabIndex = 16;
			this.MatchByPhotosBtn.Text = "Match by photos";
			this.MatchByPhotosBtn.UseVisualStyleBackColor = false;
			this.MatchByPhotosBtn.Click += new System.EventHandler(this.MatchByPhotosBtn_Click);
			// 
			// MatchByFriendsBtn
			// 
			this.MatchByFriendsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.MatchByFriendsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.MatchByFriendsBtn.Location = new System.Drawing.Point(40, 66);
			this.MatchByFriendsBtn.Name = "MatchByFriendsBtn";
			this.MatchByFriendsBtn.Size = new System.Drawing.Size(203, 35);
			this.MatchByFriendsBtn.TabIndex = 15;
			this.MatchByFriendsBtn.Text = "Match by friends";
			this.MatchByFriendsBtn.UseVisualStyleBackColor = false;
			this.MatchByFriendsBtn.Click += new System.EventHandler(this.MatchByFriendsBtn_Click);
			// 
			// m_ExplainOfMatchLabel
			// 
			this.m_ExplainOfMatchLabel.AutoSize = true;
			this.m_ExplainOfMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_ExplainOfMatchLabel.Location = new System.Drawing.Point(141, 243);
			this.m_ExplainOfMatchLabel.Name = "m_ExplainOfMatchLabel";
			this.m_ExplainOfMatchLabel.Size = new System.Drawing.Size(0, 31);
			this.m_ExplainOfMatchLabel.TabIndex = 12;
			this.m_ExplainOfMatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label3.Location = new System.Drawing.Point(601, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Your match";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(362, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "You are";
			// 
			// m_PictureProfileMatch
			// 
			this.m_PictureProfileMatch.Image = ((System.Drawing.Image)(resources.GetObject("m_PictureProfileMatch.Image")));
			this.m_PictureProfileMatch.Location = new System.Drawing.Point(535, 66);
			this.m_PictureProfileMatch.Name = "m_PictureProfileMatch";
			this.m_PictureProfileMatch.Size = new System.Drawing.Size(228, 202);
			this.m_PictureProfileMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_PictureProfileMatch.TabIndex = 4;
			this.m_PictureProfileMatch.TabStop = false;
			// 
			// m_PictureProfileFeature
			// 
			this.m_PictureProfileFeature.Image = ((System.Drawing.Image)(resources.GetObject("m_PictureProfileFeature.Image")));
			this.m_PictureProfileFeature.Location = new System.Drawing.Point(291, 66);
			this.m_PictureProfileFeature.Name = "m_PictureProfileFeature";
			this.m_PictureProfileFeature.Size = new System.Drawing.Size(216, 202);
			this.m_PictureProfileFeature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_PictureProfileFeature.TabIndex = 3;
			this.m_PictureProfileFeature.TabStop = false;
			// 
			// m_Bar
			// 
			this.m_Bar.Controls.Add(m_MainTab);
			this.m_Bar.Controls.Add(this.m_FindMatchTab);
			this.m_Bar.Controls.Add(this.secondfeature);
			this.m_Bar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_Bar.Location = new System.Drawing.Point(0, 104);
			this.m_Bar.Name = "m_Bar";
			this.m_Bar.SelectedIndex = 0;
			this.m_Bar.Size = new System.Drawing.Size(881, 413);
			this.m_Bar.TabIndex = 0;
			// 
			// FacebookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(881, 517);
			this.Controls.Add(this.m_FaceBookBarPic);
			this.Controls.Add(this.m_Bar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FacebookForm";
			this.Text = "Facebook Application";
			m_MainTab.ResumeLayout(false);
			m_MainTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FaceBookBarPic)).EndInit();
			this.secondfeature.ResumeLayout(false);
			this.secondfeature.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_BestTImePic)).EndInit();
			this.m_FindMatchTab.ResumeLayout(false);
			this.m_FindMatchTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileMatch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileFeature)).EndInit();
			this.m_Bar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_FaceBookBarPic;
		private System.Windows.Forms.BindingSource postBindingSource;
		private System.Windows.Forms.BindingSource commentsBindingSource;
		private System.Windows.Forms.BindingSource friendListBindingSource;
		private System.Windows.Forms.BindingSource groupBindingSource;
		private System.Windows.Forms.TabPage secondfeature;
		private System.Windows.Forms.Label m_BestTimeLabel;
		private System.Windows.Forms.PictureBox m_BestTImePic;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button m_BestPhotoBtn;
		internal System.Windows.Forms.TabPage m_FindMatchTab;
		private System.Windows.Forms.Label m_ExplainOfMatchLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox m_PictureProfileMatch;
		private System.Windows.Forms.PictureBox m_PictureProfileFeature;
		private System.Windows.Forms.Button sortFriendsByLastNameBtn;
		private System.Windows.Forms.Button sortFriendsByFirstNameBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox m_FriendListBox;
		private System.Windows.Forms.Label likesCountLabel1;
		private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Label nameLabel1;
		private System.Windows.Forms.DateTimePicker updateTimeDateTimePicker;
		private System.Windows.Forms.ListBox m_GroupListBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox m_RemberMeCheckbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox m_PostListBox;
		private System.Windows.Forms.Button m_PostBtn;
		private System.Windows.Forms.Button m_LoginLogoutBtn;
		private System.Windows.Forms.PictureBox m_ProfilePicMain;
		private System.Windows.Forms.TabControl m_Bar;
		private System.Windows.Forms.Button MatchByGroupsBtn;
		private System.Windows.Forms.Button MatchByPhotosBtn;
		private System.Windows.Forms.Button MatchByFriendsBtn;
	}
}
