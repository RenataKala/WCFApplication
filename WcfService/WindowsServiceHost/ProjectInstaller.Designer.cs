namespace WindowsServiceHost
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WindowsService = new System.ServiceProcess.ServiceProcessInstaller();
            this.ws = new System.ServiceProcess.ServiceInstaller();
            // 
            // WindowsService
            // 
            this.WindowsService.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.WindowsService.Password = null;
            this.WindowsService.Username = null;
            // 
            // ws
            // 
            this.ws.Description = "jas si go napraviv ";
            this.ws.DisplayName = "mojot Windows service";
            this.ws.ServiceName = "Service1";
            this.ws.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WindowsService,
            this.ws});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller WindowsService;
        private System.ServiceProcess.ServiceInstaller ws;
    }
}