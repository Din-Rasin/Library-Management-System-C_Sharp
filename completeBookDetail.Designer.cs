namespace C_Sharp_Assignment_13
{
    partial class completeBookDetail
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
            this.dataGridViewIssueBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewStudentInformation = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIssueEnrollmentNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewView_Book = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefreshView_Book = new System.Windows.Forms.Button();
            this.btnView_Book = new System.Windows.Forms.Button();
            this.btnIssueSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssueBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewView_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIssueBooks
            // 
            this.dataGridViewIssueBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewIssueBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewIssueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssueBooks.Location = new System.Drawing.Point(866, 119);
            this.dataGridViewIssueBooks.Name = "dataGridViewIssueBooks";
            this.dataGridViewIssueBooks.Size = new System.Drawing.Size(510, 484);
            this.dataGridViewIssueBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1014, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Issue Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(167, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridViewStudentInformation
            // 
            this.dataGridViewStudentInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewStudentInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudentInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentInformation.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewStudentInformation.Name = "dataGridViewStudentInformation";
            this.dataGridViewStudentInformation.Size = new System.Drawing.Size(848, 157);
            this.dataGridViewStudentInformation.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.BackColor = System.Drawing.Color.White;
            this.txtEnrollmentNo.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo.Location = new System.Drawing.Point(205, 43);
            this.txtEnrollmentNo.Multiline = true;
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(274, 39);
            this.txtEnrollmentNo.TabIndex = 7;
            this.txtEnrollmentNo.TextChanged += new System.EventHandler(this.txtrefresh_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enrollment No :";
            // 
            // txtIssueEnrollmentNo
            // 
            this.txtIssueEnrollmentNo.BackColor = System.Drawing.Color.White;
            this.txtIssueEnrollmentNo.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueEnrollmentNo.Location = new System.Drawing.Point(1113, 43);
            this.txtIssueEnrollmentNo.Multiline = true;
            this.txtIssueEnrollmentNo.Name = "txtIssueEnrollmentNo";
            this.txtIssueEnrollmentNo.Size = new System.Drawing.Size(162, 58);
            this.txtIssueEnrollmentNo.TabIndex = 11;
            this.txtIssueEnrollmentNo.TextChanged += new System.EventHandler(this.txtIssueSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(909, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enrollment No :";
            // 
            // dataGridViewView_Book
            // 
            this.dataGridViewView_Book.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewView_Book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewView_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewView_Book.Location = new System.Drawing.Point(12, 356);
            this.dataGridViewView_Book.Name = "dataGridViewView_Book";
            this.dataGridViewView_Book.Size = new System.Drawing.Size(848, 247);
            this.dataGridViewView_Book.TabIndex = 13;
            this.dataGridViewView_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(267, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Books Details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(235, 296);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(258, 48);
            this.txtsearch.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Book Name :";
            // 
            // btnRefreshView_Book
            // 
            this.btnRefreshView_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefreshView_Book.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshView_Book.ForeColor = System.Drawing.Color.Red;
            this.btnRefreshView_Book.Image = global::C_Sharp_Assignment_13.Properties.Resources.icons8_refresh_504;
            this.btnRefreshView_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshView_Book.Location = new System.Drawing.Point(671, 296);
            this.btnRefreshView_Book.Name = "btnRefreshView_Book";
            this.btnRefreshView_Book.Size = new System.Drawing.Size(176, 52);
            this.btnRefreshView_Book.TabIndex = 18;
            this.btnRefreshView_Book.Text = "Refresh";
            this.btnRefreshView_Book.UseVisualStyleBackColor = false;
            this.btnRefreshView_Book.Click += new System.EventHandler(this.btnRefreshView_Book_Click);
            // 
            // btnView_Book
            // 
            this.btnView_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnView_Book.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView_Book.ForeColor = System.Drawing.Color.Red;
            this.btnView_Book.Image = global::C_Sharp_Assignment_13.Properties.Resources.icons8_search_502;
            this.btnView_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView_Book.Location = new System.Drawing.Point(499, 296);
            this.btnView_Book.Name = "btnView_Book";
            this.btnView_Book.Size = new System.Drawing.Size(166, 51);
            this.btnView_Book.TabIndex = 17;
            this.btnView_Book.Text = "Search";
            this.btnView_Book.UseVisualStyleBackColor = false;
            this.btnView_Book.Click += new System.EventHandler(this.btnView_Book_Click);
            // 
            // btnIssueSearch
            // 
            this.btnIssueSearch.BackColor = System.Drawing.Color.SeaShell;
            this.btnIssueSearch.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnIssueSearch.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIssueSearch.Image = global::C_Sharp_Assignment_13.Properties.Resources.icons8_search_641;
            this.btnIssueSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueSearch.Location = new System.Drawing.Point(1281, 42);
            this.btnIssueSearch.Name = "btnIssueSearch";
            this.btnIssueSearch.Size = new System.Drawing.Size(95, 59);
            this.btnIssueSearch.TabIndex = 12;
            this.btnIssueSearch.UseVisualStyleBackColor = false;
            this.btnIssueSearch.Click += new System.EventHandler(this.btnIssueSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRefresh.Image = global::C_Sharp_Assignment_13.Properties.Resources.icons8_refresh_503;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(657, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(176, 44);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Image = global::C_Sharp_Assignment_13.Properties.Resources.icons8_view_501;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(485, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 43);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // completeBookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1378, 605);
            this.Controls.Add(this.btnRefreshView_Book);
            this.Controls.Add(this.btnView_Book);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewView_Book);
            this.Controls.Add(this.btnIssueSearch);
            this.Controls.Add(this.txtIssueEnrollmentNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnrollmentNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewStudentInformation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewIssueBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "completeBookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "completeBookDetail";
            this.Load += new System.EventHandler(this.completeBookDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssueBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewView_Book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIssueBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewStudentInformation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIssueSearch;
        private System.Windows.Forms.TextBox txtIssueEnrollmentNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewView_Book;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefreshView_Book;
        private System.Windows.Forms.Button btnView_Book;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
    }
}