namespace EFD2
{
	partial class CatalogForm
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
			btn_add = new Button();
			txt_desc = new TextBox();
			label1 = new Label();
			txt_name = new TextBox();
			label2 = new Label();
			btn_goBack = new Button();
			SuspendLayout();
			// 
			// btn_add
			// 
			btn_add.Location = new Point(361, 161);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(97, 50);
			btn_add.TabIndex = 0;
			btn_add.Text = "Add Catalog";
			btn_add.UseVisualStyleBackColor = true;
			btn_add.Click += btn_add_Click;
			// 
			// txt_desc
			// 
			txt_desc.Location = new Point(560, 80);
			txt_desc.Multiline = true;
			txt_desc.Name = "txt_desc";
			txt_desc.Size = new Size(195, 87);
			txt_desc.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(478, 86);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 2;
			label1.Text = "Description";
			// 
			// txt_name
			// 
			txt_name.Location = new Point(173, 80);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(145, 23);
			txt_name.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(108, 83);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 2;
			label2.Text = "Name";
			// 
			// btn_goBack
			// 
			btn_goBack.Location = new Point(65, 166);
			btn_goBack.Name = "btn_goBack";
			btn_goBack.Size = new Size(91, 40);
			btn_goBack.TabIndex = 3;
			btn_goBack.Text = "Go Back";
			btn_goBack.UseVisualStyleBackColor = true;
			btn_goBack.Click += btn_goBack_Click;
			// 
			// CatalogForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 275);
			Controls.Add(btn_goBack);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txt_name);
			Controls.Add(txt_desc);
			Controls.Add(btn_add);
			Name = "CatalogForm";
			Text = "CatalogForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_add;
		private TextBox txt_desc;
		private Label label1;
		private TextBox txt_name;
		private Label label2;
		private Button btn_goBack;
	}
}