using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerceApp.Application.Exceptions
{
    public class ItemNotFoundException(string message) : Exception(message)
    {
    }
}
