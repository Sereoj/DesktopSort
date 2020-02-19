using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    /// <summary>
    ///     Получение информации о продукте.
    /// </summary>
    public class Version
    {


        public enum StageVersion
        {
            PreAlpha,
            Alpha,
            Beta,
            Edition
        }

        public StageVersion State = StageVersion.Alpha;

        /// <summary>
        ///     Версия продукта.
        /// </summary>
        /// <returns></returns>
        public string GetVersion(bool isGetState)
        {
            return (isGetState == false? Application.ProductVersion : Application.ProductVersion + State);
        }

        public string Name(string name , bool isVersion, bool isGetState)
        {
            return (isVersion != false ? name : name + " " + GetVersion(isGetState));
        }
    }
}