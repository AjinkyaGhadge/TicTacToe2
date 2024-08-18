namespace TicTacToe
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameGrid = new TableLayoutPanel();
            gameModel = new GameModel("Ajinkya", "Nilima");
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ActionButtonGrid = new TableLayoutPanel();
            StatusLabel = new Label();
            PlayButton = new Button();
            GameGrid.SuspendLayout();
            ActionButtonGrid.SuspendLayout();
            SuspendLayout();
            // 
            // GameGrid
            // 
            GameGrid.ColumnCount = 3;
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.Controls.Add(button9, 2, 2);
            GameGrid.Controls.Add(button8, 1, 2);
            GameGrid.Controls.Add(button7, 0, 2);
            GameGrid.Controls.Add(button6, 2, 1);
            GameGrid.Controls.Add(button5, 1, 1);
            GameGrid.Controls.Add(button4, 0, 1);
            GameGrid.Controls.Add(button3, 2, 0);
            GameGrid.Controls.Add(button2, 1, 0);
            GameGrid.Controls.Add(button1, 0, 0);
            GameGrid.Location = new Point(12, 23);
            GameGrid.Name = "GameGrid";
            GameGrid.RowCount = 3;
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.Size = new Size(400, 400);
            GameGrid.TabIndex = 0;
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new Point(269, 269);
            button9.Name = "9";
            button9.Size = new Size(127, 127);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            button9.MouseEnter += button_MouseEnter;
            button9.MouseLeave += button_MouseLeave;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(136, 269);
            button8.Name = "8";
            button8.Size = new Size(127, 127);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            button8.MouseEnter += button_MouseEnter;
            button8.MouseLeave += button_MouseLeave;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(3, 269);
            button7.Name = "7";
            button7.Size = new Size(127, 127);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            button7.MouseEnter += button_MouseEnter;
            button7.MouseLeave += button_MouseLeave;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(269, 136);
            button6.Name = "6";
            button6.Size = new Size(127, 127);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            button6.MouseEnter += button_MouseEnter;
            button6.MouseLeave += button_MouseLeave;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(136, 136);
            button5.Name = "5";
            button5.Size = new Size(127, 127);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            button5.MouseEnter += button_MouseEnter;
            button5.MouseLeave += button_MouseLeave;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(3, 136);
            button4.Name = "4";
            button4.Size = new Size(127, 127);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            button4.MouseEnter += button_MouseEnter;
            button4.MouseLeave += button_MouseLeave;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(269, 3);
            button3.Name = "3";
            button3.Size = new Size(127, 127);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            button3.MouseEnter += button_MouseEnter;
            button3.MouseLeave += button_MouseLeave;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(136, 3);
            button2.Name = "2";
            button2.Size = new Size(127, 127);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            button2.MouseEnter += button_MouseEnter;
            button2.MouseLeave += button_MouseLeave;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(3, 3);
            button1.Name = "1";
            button1.Size = new Size(127, 127);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            button1.MouseEnter += button_MouseEnter;
            button1.MouseLeave += button_MouseLeave;
            // 
            // ActionButtonGrid
            // 
            ActionButtonGrid.ColumnCount = 1;
            ActionButtonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ActionButtonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ActionButtonGrid.Controls.Add(StatusLabel, 0, 0);
            ActionButtonGrid.Controls.Add(PlayButton, 0, 1);
            ActionButtonGrid.Location = new Point(12, 447);
            ActionButtonGrid.Name = "ActionButtonGrid";
            ActionButtonGrid.RowCount = 2;
            ActionButtonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActionButtonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActionButtonGrid.Size = new Size(400, 73);
            ActionButtonGrid.TabIndex = 1;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Sitka Banner Semibold", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLabel.Location = new Point(3, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(394, 36);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Click Play to Start";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayButton
            // 
            PlayButton.Location = new Point(3, 39);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(394, 31);
            PlayButton.TabIndex = 1;
            PlayButton.Text = "PLAY";
            PlayButton.UseMnemonic = false;
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 532);
            Controls.Add(ActionButtonGrid);
            Controls.Add(GameGrid);
            Name = "GameForm";
            Text = "TicTacToe";
            GameGrid.ResumeLayout(false);
            ActionButtonGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel GameGrid;
        private TableLayoutPanel ActionButtonGrid;
        private Label StatusLabel;
        private Button PlayButton;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GameModel gameModel;
    }
}