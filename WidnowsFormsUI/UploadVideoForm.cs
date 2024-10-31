using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
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
    public partial class UploadVideoForm : Form
    {
        public UploadVideoForm()
        {
            InitializeComponent();
        }
        IVideoService _videoService = new VideoManager(new EfVideoDal());
        ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());
        IUserService _userService = new UserManager(new EfUserDal());



        private void LoadCategories()
        {
            cbxCategoryLessonId.DataSource = _categoryService.GetAll();
            cbxCategoryLessonId.DisplayMember = "CategoryLessonName";
            cbxCategoryLessonId.ValueMember = "CategoryLessonId";

        }
       


        private void LoadVideo()
        {
            dgwVideo.DataSource = _videoService.GetAll();
        }

        private void cbxCategoryLessonId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwVideo.DataSource = _videoService.GetVideoByCategory(Convert.ToInt32(cbxCategoryLessonId.SelectedValue));
            }
            catch
            {

            }
        }

        private void UploadVideoForm_Load(object sender, EventArgs e)
        {
            LoadVideo();
            LoadCategories();

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _videoService.Add(new Video
            {
                CategoryLessonId = Convert.ToInt32(cbxCategoryLessonId.SelectedValue),
                VideoTitle = tbxVideoTitle.Text,
                VideoPath = lblPath.Text,
                VideoUploadedAt = DateTime.Now
                
                
            });
            MessageBox.Show("Ürün eklendi!");
            LoadVideo();
        }

        private void btnVideoPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Video dosyası uzantılarını filtrele
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.mkv|All Files|*.*";
                openFileDialog.Title = "Bir video dosyası seçin";

                // Dialogu göster ve kullanıcı bir dosya seçtiyse
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosya yolunu Label kontrolünde göster
                    lblPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwVideo.CurrentRow != null)
            {
                try
                {
                    _videoService.Delete(new Video
                    {
                        VideoId = Convert.ToInt32(dgwVideo.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    LoadVideo();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }
}
