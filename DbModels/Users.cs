using DevExpress.Xpo;

namespace p1.DbModels
{
    public class Users : XPLiteObject
    {
        long _fId;
        [Key(true)]
        public long Id
        {
            get { return _fId; }
            set { SetPropertyValue(nameof(Id), ref _fId, value); }
        }
        string _fFirstName = null!;
        [Size(50)]
        public string FirstName
        {
            get { return _fFirstName; }
            set { SetPropertyValue(nameof(FirstName), ref _fFirstName, value); }
        }


    }
}