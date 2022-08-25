using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermQ2
{
    interface IBillable
    {
        decimal Bill();
        bool Validate();
    }
}
