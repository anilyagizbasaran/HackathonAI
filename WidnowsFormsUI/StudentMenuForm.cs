using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidnowsFormsUI
{
    public partial class StudentMenuForm : Form
    {
        public StudentMenuForm()
        {
            InitializeComponent();
        }
        ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());
        IVideoService _videoService = new VideoManager(new EfVideoDal());
        private void StudentMenuForm_Load(object sender, EventArgs e)
        {

            flp1.FlowDirection = FlowDirection.TopDown;
            flp1.AutoScroll = true;
            LoadCategories();
        }
       
            

        private void LoadCategories()
        {
            foreach (var category in _categoryService.GetAll())
            {
                // Başlık Label oluşturuluyor
                Label lblCategory = new Label
                {
                    Text = $"↓ {category.CategoryLessonName}",
                    AutoSize = true,
                    Margin = new Padding(10),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };

                // İçerik Paneli oluşturuluyor
                Panel pnlContent = new Panel
                {
                    BackColor = Color.LightGray,
                    Size = new Size(flp1.Width - 20, 0), // FlowLayoutPanel genişliğine göre ayarlanır
                    Visible = false
                };

                // DataGridView oluşturuluyor
                DataGridView dataGridView = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    Visible = false // Başlangıçta görünmüyor
                };

                // Veritabanından kategoriye göre veriyi al
                var videos = _videoService.GetAll().Where(v => v.CategoryLessonId == category.CategoryLessonId).ToList();
                dataGridView.DataSource = videos; // DataGridView'e veri atıyoruz

                
                
                // Tıklama olayını ekliyoruz
                lblCategory.Click += (s, e) => TogglePanel(pnlContent, lblCategory, dataGridView);

                // FlowLayoutPanel’e başlık ve içerik ekleniyor
                pnlContent.Controls.Add(dataGridView); // DataGridView'i panel içine ekliyoruz
                flp1.Controls.Add(lblCategory);
                flp1.Controls.Add(pnlContent);
            }

        }

        // İçeriği genişletip kapatan metot
        private void TogglePanel(Panel pnlContent, Label lblCategory, DataGridView dataGridView)
        {
            /// Panel görünürlüğünü değiştir
            pnlContent.Visible = !pnlContent.Visible;

            // Buton simgesini değiştir
            lblCategory.Text = pnlContent.Visible ? $"↑ {lblCategory.Text.Substring(2)}" : $"↓ {lblCategory.Text.Substring(2)}";

            // DataGridView görünürlüğünü değiştir
            dataGridView.Visible = pnlContent.Visible;

            // Panelin yüksekliğini değiştir
            pnlContent.Height = pnlContent.Visible ? Math.Min(300, dataGridView.Rows.Count * 25 + 25) : 0; // Satır sayısına göre boyut ayarlama

            // Panelin genişliğini güncelle
            pnlContent.Width = flp1.Width - 20; // 20 piksel kenar boşluğu bırak

            // Eğer panel görünüyorsa, veri yükle
            if (pnlContent.Visible)
            {
                LoadData(dataGridView, lblCategory.Text);
            }
        }

        private void LoadData(DataGridView dataGridView, string categoryName)
        {
            // Kategori adı ile videoları al
            var category = _categoryService.GetAll().FirstOrDefault(c => $"↓ {c.CategoryLessonName}" == categoryName || $"↑ {c.CategoryLessonName}" == categoryName);
            if (category != null)
            {
                var videos = _videoService.GetAll().Where(v => v.CategoryLessonId == category.CategoryLessonId).ToList();
                dataGridView.DataSource = videos; // DataGridView'e yeni veri atıyoruz

                // Gereksiz sütunları gizle
                if (dataGridView.Columns.Count > 0) // Sütun sayısını kontrol et
                {
                    dataGridView.Columns[0].Visible = false; // İlk sütunu gizle
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[5].Visible = false;

                }
            }
        }
    }
}    

