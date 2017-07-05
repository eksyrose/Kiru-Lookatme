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
        public Form1()
        {
            InitializeComponent();
            markersOverlay = new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "marker");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tempDataSet3.base666". При необходимости она может быть перемещена или удалена.
            this.base666TableAdapter2.Fill(this.tempDataSet3.base666);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tempDataSet2.base666". При необходимости она может быть перемещена или удалена.
            this.base666TableAdapter1.Fill(this.tempDataSet2.base666);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "tempDataSet.goroda". При необходимости она может быть перемещена или удалена.
            this.gorodaTableAdapter.Fill(this.tempDataSet.goroda);
            
            //Настройки для компонента GMap.
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
                GMap.NET.AccessMode.ServerOnly; //   !!!!! можно сделать кэш и сервер + кэш !!!!!
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear(); //очищаем предыдущие маркеры
            markersOverlay = new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "marker");
            //foreach (GMap.NET.WindowsForms.Markers.GMapMarkerCross m in )
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[12].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[12].Value.ToString() != "")
            {
                string coords = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //string s = coords.Substring(0, coords.IndexOf(',') - 1);

                //MessageBox.Show(x.ToString(), y.ToString());
                //Инициализация нового КРАСНОГО маркера, с указанием его координат
                GMapMarkerGoogleRed markerR = new GMapMarkerGoogleRed(
                    new GMap.NET.PointLatLng(GetCoords(coords)[0], GetCoords(coords)[1]));
                markerR.ToolTip =
                    new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerR);
                //Текст отображаемый при наведении на маркер
                markerR.ToolTipText = name;
                markerR.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.Always;
                markersOverlay.Markers.Add(markerR);
                //GMap.NET.WindowsForms.Markers.GMapMarkerCross
                    //GMap.NET.WindowsForms.GMapMarker

                //List<DataGridViewRow> matched_rows = new List<DataGridViewRow>();
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() != "") //если дата проставлена у выбранного города
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows) //здесь мы ищем города с совпадающими датами и наносим на карту
                    {
                        if ((row.Cells[4].Value != null) && //дата не нулл
                            (!dataGridView1.CurrentRow.Cells[1].Value.ToString().Equals(row.Cells[1].Value.ToString())) && //названия не совпадают (т.е. это не та же строка, по которой кликнули)
                            (row.Cells[12].Value.ToString() != "") && //координаты есть
                            (row.Cells[4].Value.ToString().Equals(dataGridView1.CurrentRow.Cells[4].Value.ToString()))) //и совпали даты 
                        {
                            //matched_rows.Add(row);
                            //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат.
                            if (row.Cells[12].Value != null)
                            {
                                GMap.NET.WindowsForms.Markers.GMarkerGoogle = new GMarkerGoogle()
                                GMap.NET.WindowsForms.GMapMarker marker2 = new GMap.NET.WindowsForms.Markers.GMapMarkerCross GMarkerGoogle(
                    new GMap.NET.PointLatLng(39.81750, 30.52686),
                    new Bitmap("hello.png"));
                                SystemIcons.
                                marker2.ToolTipText = "Hello";
                                marker2.ToolTip.Fill = Brushes.Black;
                                marker2.ToolTip.Foreground = Brushes.White;
                                marker2.ToolTip.Stroke = Pens.Black;
                                markers.Markers.Add(marker2);
                                gMapControl1.Overlays.Add(markers);
                                GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markerG =
                                    new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
                                    new GMap.NET.PointLatLng(GetCoords(row.Cells[12].Value.ToString())[0],
                                        GetCoords(row.Cells[12].Value.ToString())[1]));
                                markerG.ToolTip =
                                    new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);

                                //Указываем, что подсказку маркера, необходимо отображать всегда.
                                markerG.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.Always;
                                markerG.ToolTipText = row.Cells[1].Value.ToString();
                                markersOverlay.Markers.Add(markerG);
                            }
                        }
                    }
                }
                //Добавляем в компонент список маркеров
                gMapControl1.Overlays.Add(markersOverlay);
                gMapControl1.Refresh();
            }
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
    }
}
