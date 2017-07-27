using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        GMap.NET.WindowsForms.GMapOverlay markersOverlay;
        List<string> cells_to_database = new List<string>();
        int usermode = 1;
        public Form1()
        {
            FormConnect f = new FormConnect();
            f.ShowDialog();
            InitializeComponent();
            markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("marker");
            Init_list();
            dataGridView1.Columns[1].HeaderText = (DateTime.Today.Year - 1).ToString();
            dataGridView1.Columns[2].HeaderText = (DateTime.Today.Year).ToString();
            LoadDataInDataGrid1(); 
        }

        private void Init_list()
        {
            cells_to_database.Add("town");
            cells_to_database.Add("0");
            cells_to_database.Add("date");
            cells_to_database.Add("status_dati");
            cells_to_database.Add("status_zayavki");
            cells_to_database.Add("podacha_s");
            cells_to_database.Add("prazdnik");
            cells_to_database.Add("znachenie");
            cells_to_database.Add("chislennost");
            cells_to_database.Add("kogda_proverit");
            cells_to_database.Add("rasstoyanie");
            cells_to_database.Add("oblast");
            cells_to_database.Add("arenda");
            cells_to_database.Add("gas_rasreshen");
            cells_to_database.Add("dlina_prazdnika");
            cells_to_database.Add("town_id");
            cells_to_database.Add("zayavka_id");
            cells_to_database.Add("coordinates");
        }

        private void SwitchUserMode() //переключение режима отображения данных в зависимости от выбранного пункта
        {
            switch (usermode)
            {
                case 1:
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    dataGridView1.Columns[13].Visible = false;
                    dataGridView1.Columns[14].Visible = false;
                    break;
                case 2:
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[9].Visible = true;
                    dataGridView1.Columns[12].Visible = false;
                    dataGridView1.Columns[13].Visible = false;
                    dataGridView1.Columns[14].Visible = false;
                    break;
                case 3:
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[12].Visible = true;
                    dataGridView1.Columns[13].Visible = true;
                    dataGridView1.Columns[14].Visible = true;
                    break;
            }
           /* if (usermode == 1)
            {
                dataGridView1.Columns[0].Visible = false;
            }*/

        }

        public void LoadDataInDataGrid1() //загрузка данных в датагрид
        {
            Npgsql.NpgsqlDataReader reader = null;
            string q = "select * from public.towns" +
                 " full outer join public.zayavki on (public.towns.town_id = public.zayavki.town_id and public.zayavki.year = " +
                //    "(select extract(year from current_date)))" +
                "cast ((select date_part('year', current_date)) as text))" +
                    //  " left outer join public.zayavki on (public.towns.town_id = public.zayavki.town_id and public.zayavki.year = " +
                    " full outer join public.zayavki as z on (public.towns.town_id = z.town_id " +
                    "and public.zayavki.prazdnik = z.prazdnik and z.year = " +
                     "cast ((select extract(year from current_date)-1) as text))" +
                 " order by towns.town_id"; //date_part('year', current_date)
            dataGridView1.Rows.Clear();
            //  Npgsql.NpgsqlDataReader reader = DataBase.WorkWithResult("select * from public.towns" +
            //     " left outer join public.zayavki on public.towns.town_id = public.zayavki.town_id order by towns.town_id"); //\"towns.town_id\"");
            if (DataBase.Start(q) != null) //если удалось подключиться
            {
                reader = DataBase.Start(q).ExecuteReader();
                while (reader.Read())
                {
                    //  try
                    //  {
                    //string result = reader.GetString(1);//Получаем значение из второго столбца! Первый это (0)!
                    //res.Add(reader.GetString(1));
                    object[] val = new object[30];
                    reader.GetValues(val);
                    //dataGridView1.Rows.Add(val[1], val[25], val[12], val[14], val[13], val[3], val[6], val[7], val[2], val[9], val[8]);
                    // }                 //0город, 1дата, 2датаэтотгод, 3стат.д., 4праздн, 5зн., 6числ., 7расст., 8обл., 9ид заявки, 10координаты
                    dataGridView1.Rows.Add(val[1], val[25], val[12], val[14], val[15], val[16], val[13], val[3], val[6], val[18], val[7], val[2], val[20], val[17], val[19], val[0], val[9], val[8]);
                    // }                 //0город, 1дата, 2датаэтгод, 3стат.д., 4стат.з,5под_с, 6пра., 7знач.,  8чи.,  9пров.,   10рас,  11обл,   12ар,    13газ,   14про,  15t,   16ид з, 17координаты
                    // catch { }
                }
            }
            else //если не удалось подключиться, т.к. были введены неправильные данные
            {
                MessageBox.Show("Кажется, вы ввели какую-то херню при подключении. В общем, подключиться к базе так и не удалось. Попробуйте заново с нормальными данными.");
                this.Close();
            }
            DataBase.End();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tempDataSet3.base666". При необходимости она может быть перемещена или удалена.
           // this.base666TableAdapter2.Fill(this.tempDataSet3.base666);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tempDataSet2.base666". При необходимости она может быть перемещена или удалена.
          //  this.base666TableAdapter1.Fill(this.tempDataSet2.base666);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tempDataSet.goroda". При необходимости она может быть перемещена или удалена.
           // this.gorodaTableAdapter.Fill(this.tempDataSet.goroda);
            gMapControl1.Bearing = 0;
            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            ///с помощью правой кнопки мыши.
            gMapControl1.CanDragMap = true;
            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.GrayScaleMode = true;
            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl1.MarkersEnabled = true;
            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 18;
            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 2;
            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            //Отказываемся от негативного режима.
            gMapControl1.NegativeMode = false;
            //Разрешаем полигоны.
            gMapControl1.PolygonsEnabled = true;
            //Разрешаем маршруты
            gMapControl1.RoutesEnabled = true;
            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl1.ShowTileGridLines = false;
            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            gMapControl1.Zoom = 5;
            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются
            //соответствующим образом.
            gMapControl1.Dock = DockStyle.Fill;
            //Указываем что будем использовать карты Google.
            gMapControl1.MapProvider =
            GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode =
                //GMap.NET.AccessMode.ServerOnly; //   !!!!! можно сделать кэш и сервер + кэш !!!!!
                GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Position = new GMap.NET.PointLatLng(51.67204, 39.1843);
            gMapControl1.ShowCenter = false;
            //dataGridView1.Columns[0].Visible 
            //gMapControl1.Manager.ExportToGMDB
            //gMapControl1.Manager.ImportFromGMDB
            //gMapControl1.ShowExportDialog
            //gMapControl1.CacheLocation
            //label1.Text = gMapControl1.CacheLocation;
            //gMapControl1.LevelsKeepInMemmory
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear(); //очищаем предыдущие маркеры
            gMapControl1.Refresh();
            gMapControl1.Update();
            gMapControl1.Zoom = gMapControl1.Zoom + 1; //костылик :) чтобы карта не глючила
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
            markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("marker");
            
            Show_same_markers();
            Refresh_labels();
        }

        public double[] GetCoords(string crds)  // преобразование координат из строки в 2 числа double
        {
            double[] res = new double[2];
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";
            //MessageBox.Show(crds.Length + crds.IndexOf(' ').ToString() + (crds.Length - crds.IndexOf(' ')).ToString());
            string s = crds.Substring(crds.IndexOf(' ') + 1, crds.Length - crds.IndexOf(' ') - 1);
            int t = crds.IndexOf(' ') + 1;
            int tt = crds.Length - crds.IndexOf(' ') - 1;
            int ttt = crds.IndexOf(',');

            res[0] = Convert.ToDouble(crds.Substring(0, crds.IndexOf(',')), ci);
            res[1] = Convert.ToDouble(crds.Substring(crds.IndexOf(' ')+1, crds.Length-crds.IndexOf(' ')-1), ci);
            return res;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataInDataGrid1();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Refresh_labels();
        }
        public void Refresh_labels() //обновляем надписи 
        {
            StringBuilder s = new StringBuilder();
            try
            {
                s.Append(dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + ", ");
                s.Append(dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + ", ");
                s.Append(dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + " чел., ");
                s.Append(dataGridView1.SelectedRows[0].Cells[7].Value.ToString() + ", ");
                s.Append(dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + " область");
            }
            catch (Exception ex)
            { }
            finally
            {
                label2.Text = s.ToString();
            }
        }
        public void Show_same_markers() //отображает на карте города с той же датой, как и у выделенного
        {
            if ((dataGridView1.RowCount != 0) && (dataGridView1.Columns.Count >= 16) && (dataGridView1.CurrentRow.Cells[17].Value.ToString() != "")) //если таблица не пуста, ячеек >=12 и у выбранного города указаны координаты
            {
                string coords = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //string s = coords.Substring(0, coords.IndexOf(',') - 1);

                //MessageBox.Show(x.ToString(), y.ToString());
                //Инициализация нового КРАСНОГО маркера, с указанием его координат
                //GMapMarkerGoogleRed markerR = new GMapMarkerGoogleRed(
                //new GMap.NET.PointLatLng(GetCoords(coords)[0], GetCoords(coords)[1]));
                GMarkerGoogle markerR = new GMarkerGoogle(new PointLatLng(GetCoords(coords)[0], GetCoords(coords)[1]), SystemIcons.Exclamation.ToBitmap());
                markerR.ToolTip =
                    new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerR);
                //Текст отображаемый при наведении на маркер
                markerR.ToolTipText = name;
                markerR.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.Always;
                markersOverlay.Markers.Add(markerR);
                //GMap.NET.WindowsForms.Markers.GMapMarkerCross
                //GMap.NET.WindowsForms.GMapMarker

                //List<DataGridViewRow> matched_rows = new List<DataGridViewRow>();
                if (dataGridView1.CurrentRow.Cells[2].Value.ToString() != "") //если дата проставлена у выбранного города
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows) //здесь мы ищем города с совпадающими датами и наносим на карту
                    {
                        if ((row.Cells[2].Value != null) && //дата не нулл
                            (!dataGridView1.CurrentRow.Cells[0].Value.ToString().Equals(row.Cells[0].Value.ToString())) && //названия не совпадают (т.е. это не та же строка, по которой кликнули)
                            (row.Cells[17].Value.ToString() != "") && //координаты есть
                            (row.Cells[2].Value.ToString().Equals(dataGridView1.CurrentRow.Cells[2].Value.ToString()))) //и совпали даты 
                        {
                            //matched_rows.Add(row);
                            //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат.
                            if (row.Cells[17].Value != null)
                            {
                                GMarkerGoogle markerG = new GMarkerGoogle(new PointLatLng(GetCoords(row.Cells[17].Value.ToString())[0],
                                        GetCoords(row.Cells[17].Value.ToString())[1]), SystemIcons.Hand.ToBitmap());

                                //GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markerG =
                                //new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
                                //  new GMap.NET.PointLatLng(GetCoords(row.Cells[12].Value.ToString())[0],
                                //    GetCoords(row.Cells[12].Value.ToString())[1]));
                                markerG.ToolTip =
                                    new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);

                                //Указываем, что подсказку маркера, необходимо отображать всегда.
                                markerG.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.Always;
                                markerG.ToolTipText = row.Cells[0].Value.ToString();
                                markersOverlay.Markers.Add(markerG);
                            }
                        }
                    }
                }
                //Добавляем в компонент список маркеров
                gMapControl1.Overlays.Add(markersOverlay);
                gMapControl1.Refresh();
                gMapControl1.Update();
                gMapControl1.Zoom = gMapControl1.Zoom + 1; //костылик :) чтобы карта не глючила
                gMapControl1.Zoom = gMapControl1.Zoom - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e) //создаём заявку для выбранного города
        {
            Npgsql.NpgsqlDataReader reader = null;
            if ((dataGridView1.SelectedRows[0].Cells[0].Value.ToString() != "") && 
                (dataGridView1.SelectedRows[0].Cells[11].Value.ToString() != "") &&
                (dataGridView1.SelectedRows[0].Cells[7].Value.ToString() != ""))
            {
                //try
               // {
                    string q = "select town, town_id from public.towns where town='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() +
                        "' and oblast='" +
                        dataGridView1.SelectedRows[0].Cells[11].Value.ToString()
                        + "' and znachenie='" + dataGridView1.SelectedRows[0].Cells[7].Value.ToString() + "';";
                if (DataBase.Start(q) != null) //если удалось подключиться
                    reader = DataBase.Start(q).ExecuteReader();
                else //если не удалось подключиться, т.к. были введены неправильные данные
                {
                    MessageBox.Show("Кажется, вы ввели какую-то херню при подключении. В общем, подключиться к базе так и не удалось. Мои извинения.");
                    this.Close();
                }               
                while (reader.Read()) //начинаем получать айди города
                {
                        object[] val = new object[20];
                        reader.GetValues(val);
                        Form3 f = new Form3(val[0].ToString(), val[1].ToString()); //запускаем форму, передавая ей айди
                        if (f.ShowDialog()==DialogResult.OK)
                            LoadDataInDataGrid1();
                    }
                    DataBase.End();
                    //LoadDataInDataGrid1();
              //  }
              //  catch { }
                // Form3 f = new Form3(dataGridView1.SelectedRows[0].Cells[);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[16].Value.ToString() != "")
            {
                FormDelete f = new FormDelete();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string q = "delete from public.zayavki where zayavka_id='" +
                        dataGridView1.SelectedRows[0].Cells[16].Value.ToString() + "';";
                    DataBase.Work(q);
                    LoadDataInDataGrid1();
                }
            }
            else MessageBox.Show("Тут и так нет заявки!");   
        }

       /* private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) usermode = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) usermode = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) usermode = 3;
        }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) dataGridView1.Columns[17].Visible = true;
            else dataGridView1.Columns[17].Visible = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) usermode = 1;
            if (radioButton2.Checked == true) usermode = 2;
            if (radioButton3.Checked == true) usermode = 3;
            SwitchUserMode();
            LoadDataInDataGrid1();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) usermode = 1;
            if (radioButton2.Checked == true) usermode = 2;
            if (radioButton3.Checked == true) usermode = 3;
            SwitchUserMode();
            LoadDataInDataGrid1();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) usermode = 1;
            if (radioButton2.Checked == true) usermode = 2;
            if (radioButton3.Checked == true) usermode = 3;
            SwitchUserMode();
            LoadDataInDataGrid1();
        }
    }
}
