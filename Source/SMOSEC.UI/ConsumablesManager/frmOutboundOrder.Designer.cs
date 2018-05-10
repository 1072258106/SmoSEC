namespace SMOSEC.UI.ConsumablesManager
{
    partial class frmOutboundOrder : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmOutboundOrder()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Title1 = new SMOSEC.UI.UserControl.MenuTitle();
            this.btnAdd = new Smobiler.Core.Controls.Button();
            this.gridAssRows = new Smobiler.Core.Controls.GridView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.Black;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "���ⵥ�б�";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FontSize = 15F;
            this.btnAdd.Location = new System.Drawing.Point(0, 42);
            this.btnAdd.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 33);
            this.btnAdd.Text = "��ӳ��ⵥ";
            this.btnAdd.Press += new System.EventHandler(this.btnAdd_Press);
            // 
            // gridAssRows
            // 
            this.gridAssRows.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.gridAssRows.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridAssRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAssRows.Location = new System.Drawing.Point(0, 75);
            this.gridAssRows.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.gridAssRows.Name = "gridAssRows";
            this.gridAssRows.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridAssRows.PageSizeTextSize = 11F;
            this.gridAssRows.Size = new System.Drawing.Size(300, 425);
            this.gridAssRows.TemplateControlName = "frmOutboundOrderLayout";
            // 
            // frmOutboundOrder
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.btnAdd,
            this.gridAssRows});
            this.DrawerName = "LeftMenu";
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmOutboundOrder_KeyDown);
            this.Load += new System.EventHandler(this.frmOutboundOrder_Load);
            this.Name = "frmOutboundOrder";

        }
        #endregion

        private UserControl.MenuTitle Title1;
        internal Smobiler.Core.Controls.Button btnAdd;
        internal Smobiler.Core.Controls.GridView gridAssRows;
    }
}