using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudyApp01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // XAML Binding 방식
        public List<KeyValuePair<string, string>> divisionItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadDivisionFromDatabase(); // 항상 이렇게 사용
        }

        private void loadDivisionFromDatabase()
        {   
            divisionItems = new List<KeyValuePair<string, string>>(); // 반드시 객체 생성 초기화 실행!
            // 1. 연결문자열
            string connectionString = "Sever=localhost;" +
                                      "Database = bookrentalshop;" +
                                      "Uid = root;" +
                                      "Pwd = 12345;" +
                                      "CharSet=utf8";


            // 2. 쿼리문자열
            string query = "SELECT division, names FROM divtbl";

            // 3. DB 연결 객체
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // 4. DB Command 객체 
                    MySqlCommand mysqlCommand = new MySqlCommand(query, conn);
                    // 5. DB 실행결과 리더 객체
                    MySqlDataReader reader = mysqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        // 6. DB에서 읽은 데이터
                        var division = reader.GetString("division");
                        var names = reader.GetString("names");
                        // 7. XAML Binding 방식으로 데이터 저장
                        divisionItems.Add(new KeyValuePair<string, string>(division, names));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"DB 연결 실패 : {ex.Message}", "오류",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}