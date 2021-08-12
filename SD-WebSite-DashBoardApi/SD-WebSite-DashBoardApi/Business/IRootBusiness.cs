namespace SD_WebSite_DashBoardApi.Business
{
    public interface IRootBusiness
    {
        object CreateUser(string user, string password, int modelo);
        object DeleteUser(int id);
    }
}