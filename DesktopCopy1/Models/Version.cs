using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    /// <summary>
    ///     Получение информации о продукте.
    /// </summary>
    public class Version
    {
        /// <summary>
        /// </summary>
        public enum StageVersion
        {
            PreAlpha,
            Alpha,
            Beta,
            Edition
        }

        public StageVersion State = StageVersion.Beta;

        /// <summary>
        ///     Версия продукта.
        /// </summary>
        /// <returns></returns>
        public string GetVersion(bool isGetState)
        {
            return (isGetState == false? Application.ProductVersion : Application.ProductVersion + State);
        }
    }
}