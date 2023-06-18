namespace QuanLyThuVien
{
    internal static class Program
    {
        public static string ConnectionString { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyThuVien;Integrated Security = True;";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new NhapDauSachMoi());

       

        }
    }
}