
namespace LibraryApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtReceiveDate = new System.Windows.Forms.TextBox();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.btnListBooks = new System.Windows.Forms.Button();
            this.btnRemoveBooks = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(159, 294);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 29);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(64, 68);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(43, 17);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(159, 68);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(120, 22);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(159, 113);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(120, 22);
            this.txtBookName.TabIndex = 4;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(64, 113);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(89, 17);
            this.lblKitapAdi.TabIndex = 3;
            this.lblKitapAdi.Text = "Book Name :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(159, 156);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(120, 22);
            this.txtAuthor.TabIndex = 6;
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_KeyPress);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(64, 156);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 17);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author:";
            // 
            // txtReceiveDate
            // 
            this.txtReceiveDate.Location = new System.Drawing.Point(159, 198);
            this.txtReceiveDate.Name = "txtReceiveDate";
            this.txtReceiveDate.Size = new System.Drawing.Size(120, 22);
            this.txtReceiveDate.TabIndex = 8;
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Location = new System.Drawing.Point(49, 198);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(104, 17);
            this.lblReceiveDate.TabIndex = 7;
            this.lblReceiveDate.Text = "Receiving Date";
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Location = new System.Drawing.Point(159, 244);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(120, 22);
            this.txtReturnDate.TabIndex = 10;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(64, 244);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(89, 17);
            this.lblReturnDate.TabIndex = 9;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // btnListBooks
            // 
            this.btnListBooks.Location = new System.Drawing.Point(52, 345);
            this.btnListBooks.Name = "btnListBooks";
            this.btnListBooks.Size = new System.Drawing.Size(120, 29);
            this.btnListBooks.TabIndex = 11;
            this.btnListBooks.Text = "List Books";
            this.btnListBooks.UseVisualStyleBackColor = true;
            this.btnListBooks.Click += new System.EventHandler(this.btnListBooks_Click);
            // 
            // btnRemoveBooks
            // 
            this.btnRemoveBooks.Location = new System.Drawing.Point(191, 345);
            this.btnRemoveBooks.Name = "btnRemoveBooks";
            this.btnRemoveBooks.Size = new System.Drawing.Size(120, 29);
            this.btnRemoveBooks.TabIndex = 12;
            this.btnRemoveBooks.Text = "Remove Books";
            this.btnRemoveBooks.UseVisualStyleBackColor = true;
            this.btnRemoveBooks.Click += new System.EventHandler(this.btnRemoveBooks_Click);
            // 
            // txtList
            // 
            this.txtList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtList.ForeColor = System.Drawing.Color.Maroon;
            this.txtList.Location = new System.Drawing.Point(29, 383);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(282, 123);
            this.txtList.TabIndex = 13;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMain.Location = new System.Drawing.Point(21, 21);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(290, 32);
            this.lblMain.TabIndex = 14;
            this.lblMain.Text = "Your Library System ! ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 518);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnRemoveBooks);
            this.Controls.Add(this.btnListBooks);
            this.Controls.Add(this.txtReturnDate);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.txtReceiveDate);
            this.Controls.Add(this.lblReceiveDate);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.btnAddBook);
            this.Name = "Form1";
            this.Text = "Library APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtReceiveDate;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button btnListBooks;
        private System.Windows.Forms.Button btnRemoveBooks;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label lblMain;
    }
}

