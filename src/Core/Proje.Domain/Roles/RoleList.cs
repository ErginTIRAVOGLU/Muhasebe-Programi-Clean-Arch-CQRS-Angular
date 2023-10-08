using Proje.Domain.AppEntities.Identity;

namespace Proje.Domain.Roles
{
    public sealed class RoleList
    {
        public static List<AppRole> GetStaticRoles()
        {
            List<AppRole> appRoles = new List<AppRole>();
            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFCreateCode,
                name: UCAFCreateName
                ));

            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFUpdateCode,
                name: UCAFUpdateName
               ));

            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFRemoveCode,
                name: UCAFRemoveName
             ));

            appRoles.Add(new AppRole(
                title: UCAF,
                code: UCAFReadCode,
                name: UCAFReadName
             ));

            return appRoles;
        }

        #region RoleTitleNames
        public static string UCAF = "Hesap Planı";
        #endregion

        #region RoleCodeAndNames
        public static string UCAFCreateCode = "UCAF.Create";
        public static string UCAFCreateName = "Hesap Planı Kayıt";

        public static string UCAFUpdateCode = "UCAF.Update";
        public static string UCAFUpdateName = "Hesap Planı Güncelle";

        public static string UCAFRemoveCode = "UCAF.Remove";
        public static string UCAFRemoveName = "Hesap Planı Sil";

        public static string UCAFReadCode = "UCAF.Read";
        public static string UCAFReadName = "Hesap Planı Görüntüle";

        #endregion



    }
}
