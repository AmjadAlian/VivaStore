namespace VivaStore.PL.Helpers
{
    public class FilesSettings
    {
        public static string UploadFile(IFormFile file,string folderName)
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files",folderName);
            string fileName = $"{Guid.NewGuid()}{file.FileName}";
            string filePath = Path.Combine(folderPath, fileName);
            var fileStream = new FileStream(filePath,FileMode.Create);

            file.CopyTo(fileStream);
            return fileName;
        }
        public static void DeleteFile (string fileName , string folderName)
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName,fileName);
            if (File.Exists(folderPath) )
            {
                File.Delete(folderPath);
            }
        }
    }
}
