using System;
namespace DataAccess.Exceptions
{
    [Serializable]
    class UnitDoesNotExistException: Exception
    {
        public UnitDoesNotExistException()
            : base("Unit doesn't exist.") { }
    }
}
