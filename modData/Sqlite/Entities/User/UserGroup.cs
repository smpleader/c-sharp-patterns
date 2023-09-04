

namespace modData.Sqlite.Entities.User
{
    internal class UserGroup
    {
        public int IdUser { get; set; }
        public int IdGroup { get; set; }
        public override string ToString() { return IdGroup + " " + IdUser; }

    }
}
