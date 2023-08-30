using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TA30_1_sgallego.Model
{
    public class Video
    {
        private static List<Video> listVideos = new List<Video>();

        public static void EditVideo(Video videoEdit)
        {
            try
            {
                int indice = listVideos.FindIndex(video => videoEdit.Id == videoEdit.Id);
                listVideos[indice] = videoEdit;
            } catch(Exception) { }
        }
        public static void DeleteVideo(int id)
        {
            try
            {
                int indice = listVideos.FindIndex(video => video.Id == id);
                listVideos.RemoveAt(indice);
            }
            catch (Exception) { }
        }

        public static void AddVideo(Video video)
        {
                try
                {
                    listVideos.Add(video);
                }
                catch (Exception)
                {

                }
        }

        public static List<Video> GetVideos()
        {
            return listVideos;
        }

        [Key]
        public int Id { get; set; }

        public String Titulo { get; set; }

        public String Director { get; set; }

        public Cliente Cliente { get; set; }
    }
}