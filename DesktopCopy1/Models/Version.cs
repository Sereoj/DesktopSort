using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    /// <summary>
    /// Получение информации о продукте.
    /// </summary>
    public class Version
    {
        /// <summary>
        /// Версия продукта.
        /// </summary>
        /// <returns></returns>
        public string GetVersion()
        {
            return Application.ProductVersion;
        }
    }
}