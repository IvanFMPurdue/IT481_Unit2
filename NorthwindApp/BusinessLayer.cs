using System.Collections.Generic;

namespace NorthwindApp
{
    class BusinessLayer
    {
        private DataAccessLayer _dal;

        public BusinessLayer(string connection)
        {
            _dal = new DataAccessLayer(connection);
        }

        public int GetNumberOfCustomers()
        {
            return _dal.GetNumberOfCustomers();
        }

        public List<string> GetCustomerLastName()
        {
            return _dal.GetCustomerLastName();
        }
    }
}
